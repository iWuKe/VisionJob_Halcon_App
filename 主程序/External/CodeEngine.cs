using Microsoft.CSharp;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
namespace dotNetLab.Debug
{
    public class CodeEngine
    {
       public readonly string SHIKII_DEBUG_DLL_NAME = "SHIKII_DEBUG_DLL.dll";
        readonly string SHIKII_DEBUG_DLL_NAMESPACE = "shikii.debug";
        readonly string SHIKII_DEBUG_DLL_CLASSNAME = "ShikiiDebugPlatform";
        string encryptKey = "Oyea";    //定义密钥  
        Type type;
        Object objCodeEngine;
        System.Reflection.PropertyInfo[] PropertyInfos;

        MethodInfo[] MethodInfos;
        bool CheckSHIKII_DEBUG_DLL()
        {
            bool bisDebugFileExist = File.Exists(SHIKII_DEBUG_DLL_NAME);
            return bisDebugFileExist;
        }
        void Load(String strAssemblyName, String ClassFullName_IncludeNamespace)
        {
            try
            {
                //  objDBEngine = System.Activator.CreateInstanceFrom(strAssemblyName, ClassFullName_IncludeNamespace);
                objCodeEngine = Assembly.LoadFile(strAssemblyName).CreateInstance(ClassFullName_IncludeNamespace);
                type = objCodeEngine.GetType();
                MethodInfos = type.GetMethods();

            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public bool BeginInvoke()
        {
            if (CheckSHIKII_DEBUG_DLL())
            {
                if (type == null)
                    Load(SHIKII_DEBUG_DLL_NAME, Path.Combine(SHIKII_DEBUG_DLL_NAMESPACE, SHIKII_DEBUG_DLL_CLASSNAME));
                return false;
            }
            else
            {
                return true;
            }
        }
        public Object EndInvoke(String strMethodName, Object[] objArgs)
        {
            MethodInfo Mif = null;
            for (int i = 0; i < MethodInfos.Length; i++)
            {
                if (MethodInfos[i].Name.Equals(strMethodName))
                {
                    Mif = MethodInfos[i];
                }
            }
            if (Mif != null)
                return Mif.Invoke(objCodeEngine, objArgs);
            else
                return null;
        }
        public String LastErrorInfo = null;
        //        方法定义完后，将方法具体内容插入模板中，并生成编译，如果编译通过，则生成dll文件。编译不通过，获取错误信息。

        //如：

        //        CompilerResults result = DebugRun(整个cs代码, dll保存路径);

        //        通过判断 result.Errors.Count 是否为0，得出是否编译通过。



        /// <summary>
        /// 动态编译并执行代码
        /// </summary>
        /// <param name="code">代码</param>
        /// <returns>返回输出内容</returns>
        public bool CompileDll(string code, string strOuputDllPath)
        {
            ICodeCompiler complier = new CSharpCodeProvider().CreateCompiler();
            //设置编译参数
            CompilerParameters paras = new CompilerParameters();
            //引入第三方dll
            paras.ReferencedAssemblies.Add("System.dll");
            paras.ReferencedAssemblies.Add("System.Data.dll");
            paras.ReferencedAssemblies.Add("System.Windows.Forms.dll");
            paras.ReferencedAssemblies.Add("System.Xml.dll");
            paras.ReferencedAssemblies.Add("System.Core.dll");
            paras.ReferencedAssemblies.Add("Microsoft.CSharp.dll");


            //引入自定义dll
            //  paras.ReferencedAssemblies.Add(@"D:\自定义方法\自定义方法\bin\LogHelper.dll");
            //是否内存中生成输出 
            paras.GenerateInMemory = false;
            //是否生成可执行文件
            paras.GenerateExecutable = false;
            paras.OutputAssembly = strOuputDllPath;

            //编译代码
            CompilerResults result = complier.CompileAssemblyFromSource(paras, code);
            if (result.Errors.Count == 0)
            {
                 
                return true;
            }
            else
            {

                StringBuilder stringBuilder = new StringBuilder();
                for (int i = 0; i < result.Errors.Count; i++)
                {
                    stringBuilder.AppendFormat("{0}:{1}\r\n", result.Errors[i].Line, result.Errors[i].ErrorText);
                }
                this.LastErrorInfo = stringBuilder.ToString();
                 
                return false;
            }
        }



        #region 加密字符串  
        /// <summary> /// 加密字符串   
        /// </summary>  
        /// <param name="str">要加密的字符串</param>  
        /// <returns>加密后的字符串</returns>  
        public string Encrypt(string str)
        {
            DESCryptoServiceProvider descsp = new DESCryptoServiceProvider();   //实例化加/解密类对象   

            byte[] key = Encoding.Unicode.GetBytes(encryptKey); //定义字节数组，用来存储密钥    

            byte[] data = Encoding.Unicode.GetBytes(str);//定义字节数组，用来存储要加密的字符串  

            MemoryStream MStream = new MemoryStream(); //实例化内存流对象      

            //使用内存流实例化加密流对象   
            CryptoStream CStream = new CryptoStream(MStream, descsp.CreateEncryptor(key, key), CryptoStreamMode.Write);

            CStream.Write(data, 0, data.Length);  //向加密流中写入数据      

            CStream.FlushFinalBlock();              //释放加密流      

            return Convert.ToBase64String(MStream.ToArray());//返回加密后的字符串  
        }
        #endregion

        #region 解密字符串   
        /// <summary>  
        /// 解密字符串   
        /// </summary>  
        /// <param name="str">要解密的字符串</param>  
        /// <returns>解密后的字符串</returns>  
        public string Decrypt(string str)
        {
            DESCryptoServiceProvider descsp = new DESCryptoServiceProvider();   //实例化加/解密类对象    

            byte[] key = Encoding.Unicode.GetBytes(encryptKey); //定义字节数组，用来存储密钥    

            byte[] data = Convert.FromBase64String(str);//定义字节数组，用来存储要解密的字符串  

            MemoryStream MStream = new MemoryStream(); //实例化内存流对象      

            //使用内存流实例化解密流对象       
            CryptoStream CStream = new CryptoStream(MStream, descsp.CreateDecryptor(key, key), CryptoStreamMode.Write);

            CStream.Write(data, 0, data.Length);      //向解密流中写入数据     

            CStream.FlushFinalBlock();               //释放解密流      

            return Encoding.Unicode.GetString(MStream.ToArray());       //返回解密后的字符串  
        }
        #endregion
    }
}
