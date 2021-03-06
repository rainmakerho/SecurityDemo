using System.Web.Mvc;
// <copyright file="XSSControllerTest.cs">Copyright ©  2016</copyright>

using System;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WebSecurityDemo.Controllers;

namespace WebSecurityDemo.Controllers.Tests
{
    [TestClass]
    [PexClass(typeof(XSSController))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class XSSControllerTest
    {

        [PexMethod]
        public ActionResult T1P1([PexAssumeUnderTest]XSSController target, string id)
        {
            ActionResult result = target.T1P1(id);
            return result;
            // TODO: add assertions to method XSSControllerTest.T1P1(XSSController, String)
        }
    }
}
