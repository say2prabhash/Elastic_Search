using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SearchIndexer;
using System.Collections.Generic;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            //SampleDataFileReader reader = new SampleDataFileReader();
            //IEnumerable<SampleDataFileRow> rows= reader.ReadAllRows();
            SampleData data1 = new SampleData("Sun Shine","Hotel","Bahamas");
            SampleData data2 = new SampleData("Sun Flower", "Hotel", "Miami");
            SampleData data3 = new SampleData("Sun and Love", "Hotel", "Florida");
            List<SampleData> rows = new List<SampleData>();
            rows.Add(data1);
            rows.Add(data2);
            rows.Add(data3);
            LuceneService service = new LuceneService();
            service.BuildIndex(rows);
            rows=service.Search("Su");
        }
    }
}
