
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Xml.Serialization;
namespace BelieveOrNotBelieve
{
    // Класс для вопроса    
    [Serializable]
    public class Question
    {
        public string text;       // Текст вопроса
        public bool trueFalse;// Правда или нет
                              // Здесь мы нарушаем правила инкапсуляции и эти поля нужно было бы реализовать через открытые свойства, но для упрощения примера оставим так
                              // Вам же предлагается сделать поля закрытыми и реализовать открытые свойства Text и TrueFalse
                              // Для сериализации должен быть пустой конструктор.
        public Question()
        {
        }
        public Question(string text, bool trueFalse)
        {
            this.text = text;
            this.trueFalse = trueFalse;
        }
    }
    // Класс для хранения списка вопросов. А также для сериализации в XML и десериализации из XML
    class TrueFalse
    {
        string fileName;
        List<Question> list;
        public string FileName
        {
            set { fileName = value; }
        }
        public TrueFalse(string fileName)
        {
            Debug.Listeners.Add(new TextWriterTraceListener(Console.Out));
            Debug.AutoFlush = true;
            this.fileName = fileName;
            list = new List<Question>();
        }
        public void Add(string text, bool trueFalse)
        {
            list.Add(new Question(text, trueFalse));
        }
        public void Remove(int index)
        {
            if (list != null && index < list.Count && index >= 0) list.RemoveAt(index);
        }
        // Индексатор - свойство для доступа к закрытому объекту
        public Question this[int index]
        {
            get
            {
                try
                {
                    return list[index];
                }
                catch (IndexOutOfRangeException e)
                {
                    Debug.WriteLine($"IndexOutOfRangeException: {0}", e.Source);
                    return this[0];
                }
            }
        }
        public void Save()
        {
            XmlSerializer xmlFormat = new XmlSerializer(typeof(List<Question>));
            try
            {
                Stream fStream = new FileStream(fileName, FileMode.Create, FileAccess.Write);
                xmlFormat.Serialize(fStream, list);
                fStream.Close();
            }
            catch (InternalBufferOverflowException e)
            {
                Debug.WriteLine($"InternalBufferOverflowException: {0}", e.Source);
            }
        }
        public void Load()
        {
            XmlSerializer xmlFormat = new XmlSerializer(typeof(List<Question>));
            try
            {
                Stream fStream = new FileStream(fileName, FileMode.Open, FileAccess.Read);
                list = (List<Question>)xmlFormat.Deserialize(fStream);
                fStream.Close();
            }
            catch (FileNotFoundException e)
            {
                Debug.WriteLine($"FileNotFoundException: {0}", e.Source);
            }
        }
        public int Count
        {
            get { return list.Count; }
        }
    }
}