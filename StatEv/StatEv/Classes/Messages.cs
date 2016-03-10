using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.IO;
using System.Reflection;
using System.Xml;

public class Messages
{
    public class Message
    {
        [XmlAttribute("name")]
        public string name { get; set; }
        public string value { get; set; }
    }

    [XmlElement("Message")]
    public List<Message> MessageList { get; set; }

    private static DateTime LastWriteTime = DateTime.MinValue;

    protected static Messages mInstance = null;

    public static Messages Instance
    {
        get { return GetInstance(); }
    }

    public static Messages GetInstance()
    {
        string Filename = StatEv.Properties.Settings.Default.Language == "EN" ? "Messages_en.xml" : "Messages_ru.xml";
        string fn = "AppData\\" + Filename;
        if (mInstance == null || (File.Exists(fn) && File.GetLastWriteTime(fn) != LastWriteTime))
        {

            XmlSerializer serializer = new XmlSerializer(typeof(Messages));
            Stream stream = null;

            try
            {
                // check App_Data folder
                if (File.Exists(fn))
                {
                    stream = new FileStream(fn, FileMode.Open, FileAccess.Read);
                }
                // if nothing found previously do load default values from executing assembly
                if (stream == null)
                {
                    var assembly = Assembly.GetExecutingAssembly();
                    string FileNS = assembly.FullName.Split(new[] { ',' })[0];
                    stream = assembly.GetManifestResourceStream(FileNS + "." + Filename);
                }

                if (stream == null)
                {
                    throw new Exception(Filename + " not found");
                }
                XmlTextReader reader = new XmlTextReader(stream);
                try
                {
                    mInstance = (Messages)serializer.Deserialize(reader);
                }
                finally
                {
                    reader.Close();
                }
                LastWriteTime = File.GetLastWriteTime(fn);
            }
            finally
            {
                try { if (stream != null) stream.Close(); }
                catch { }
            }
        }
        return mInstance;
    }
    public static string GetMessage(string id)
    {
        return Instance[id];
    }

    public static string FormatMessage(string Message, params object[] args)
    {
        return string.Format(Message, args);
    }

    public string this[string Id]
    {
        get
        {
            if (MessageList == null || MessageList.Count == 0)
                return "ERROR! Messages not loaded";

            var res = MessageList.Find(e => e.name == Id);
            if (res != null)
            {
                if (res.value != null)
                    return res.value;
            }
            return string.Format("ERROR! Message {0} not found", Id);
        }
    }

    public static string AppTitle { get { return Instance["AppTitle"]; } }
    public static string AppVersion { get { return Instance["AppVersion"]; } }
    public static string AppAuthor { get { return Instance["AppAuthor"]; } }

    #region MenuItemTitles
    public static string MenuItem_File { get { return Instance["MenuItem_File"]; } }
    public static string MenuItem_Load { get { return Instance["MenuItem_Load"]; } }
    public static string MenuItem_Save { get { return Instance["MenuItem_Save"]; } }
    public static string MenuItem_Exit { get { return Instance["MenuItem_Exit"]; } }
    public static string MenuItem_Settings { get { return Instance["MenuItem_Settings"]; } }
    public static string MenuItem_Language { get { return Instance["MenuItem_Language"]; } }
    public static string MenuItem_StatsRange { get { return Instance["MenuItem_StatsRange"]; } }
    public static string MenuItem_About { get { return Instance["MenuItem_About"]; } }
    #endregion
}