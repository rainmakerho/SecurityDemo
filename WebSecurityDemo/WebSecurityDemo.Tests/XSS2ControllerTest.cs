using System.Web.Mvc;
// <copyright file="XSS2ControllerTest.cs">Copyright ©  2016</copyright>

using System;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WebSecurityDemo.Controllers;

namespace WebSecurityDemo.Controllers.Tests
{
    [TestClass]
    [PexClass(typeof(XSS2Controller))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class XSS2ControllerTest
    {

        [PexMethod]
        public ActionResult Index([PexAssumeUnderTest]XSS2Controller target, string id)
        {
            ActionResult result = target.Index(id);
            return result;
            // TODO: add assertions to method XSS2ControllerTest.Index(XSS2Controller, String)
        }
    }
}
