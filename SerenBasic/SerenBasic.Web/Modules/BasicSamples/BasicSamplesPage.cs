﻿using Microsoft.AspNetCore.Mvc;
using Serenity.Web;

namespace SerenBasic.BasicSamples.Pages
{
    [PageAuthorize, Route("BasicSamples/[action]")]
    public partial class BasicSamplesController : Controller
    {
    }
}
