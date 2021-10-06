using System;
using Newtonsoft.Json;


namespace firstLibrary
{
    
    public class Hello
    {
        public string Value { get; set; }
        public Hello() { }
    }
    public class Class1
    {
        public string Serialize()
        {
            Hello testObject = new Hello() { Value = "this is a test" };
            return JsonConvert.SerializeObject(testObject);
        }
    }
}
