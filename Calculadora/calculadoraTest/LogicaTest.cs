using cnCalculadora;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace calculadoraTest
{
    
    
    /// <summary>
    ///Se trata de una clase de prueba para LogicaTest y se pretende que
    ///contenga todas las pruebas unitarias LogicaTest.
    ///</summary>
    [TestClass()]
    public class LogicaTest
    {


        private TestContext testContextInstance;

        /// <summary>
        ///Obtiene o establece el contexto de la prueba que proporciona
        ///la información y funcionalidad para la ejecución de pruebas actual.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Atributos de prueba adicionales
        // 
        //Puede utilizar los siguientes atributos adicionales mientras escribe sus pruebas:
        //
        //Use ClassInitialize para ejecutar código antes de ejecutar la primera prueba en la clase 
        //[ClassInitialize()]
        //public static void MyClassInitialize(TestContext testContext)
        //{
        //}
        //
        //Use ClassCleanup para ejecutar código después de haber ejecutado todas las pruebas en una clase
        //[ClassCleanup()]
        //public static void MyClassCleanup()
        //{
        //}
        //
        //Use TestInitialize para ejecutar código antes de ejecutar cada prueba
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{
        //}
        //
        //Use TestCleanup para ejecutar código después de que se hayan ejecutado todas las pruebas
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{
        //}
        //
        #endregion


        /// <summary>
        ///Una prueba de restarNumeros
        ///</summary>
        [TestMethod()]
        public void restarNumerosTest()
        {
            Logica target = new Logica(); // TODO: Inicializar en un valor adecuado
            int numero1 = 8; // TODO: Inicializar en un valor adecuado
            int numero2 = 4; // TODO: Inicializar en un valor adecuado
            int expected = 4; // TODO: Inicializar en un valor adecuado
            int actual;
            actual = target.restarNumeros(8,4);
            Assert.AreEqual(expected, actual);
           
        }

        /// <summary>
        ///Una prueba de sumarNumeros
        ///</summary>
        [TestMethod()]
        public void sumarNumerosTest()
        {
            Logica target = new Logica(); // TODO: Inicializar en un valor adecuado
            int numero1 = 2; // TODO: Inicializar en un valor adecuado
            int numero2 = 3; // TODO: Inicializar en un valor adecuado
            int expected = 5; // TODO: Inicializar en un valor adecuado
            int actual;
            actual = target.sumarNumeros(2, 3);
           
            Assert.AreEqual(expected, actual);

            
          
        }

        /// <summary>
        ///Una prueba de MultiplicarNumeros
        ///</summary>
        [TestMethod()]
        public void MultiplicarNumerosTest()
        {
            Logica target = new Logica(); // TODO: Inicializar en un valor adecuado
            int numero1 = 2; // TODO: Inicializar en un valor adecuado
            int numero2 = 2; // TODO: Inicializar en un valor adecuado
            int expected = 4; // TODO: Inicializar en un valor adecuado
            int actual;
            actual = target.MultiplicarNumeros(2,2);
            Assert.AreEqual(expected, actual);
           
        }

        /// <summary>
        ///Una prueba de DivisionNumeros
        ///</summary>
        [TestMethod()]
        public void DivisionNumerosTest()
        {
            Logica target = new Logica(); // TODO: Inicializar en un valor adecuado
            int numero1 = 4; // TODO: Inicializar en un valor adecuado
            int numero2 = 2; // TODO: Inicializar en un valor adecuado
            int expected = 2; // TODO: Inicializar en un valor adecuado
            int actual;
            actual = target.DivisionNumeros(4,2);
            Assert.AreEqual(expected, actual);
          
        }
    }
}
