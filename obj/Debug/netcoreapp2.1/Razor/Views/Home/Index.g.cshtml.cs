#pragma checksum "C:\Users\user\source\repos\login\login\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "15bcbd22f9fc3d540b1592a8cb5ce8403fcee279"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Users\user\source\repos\login\login\Views\_ViewImports.cshtml"
using login;

#line default
#line hidden
#line 2 "C:\Users\user\source\repos\login\login\Views\_ViewImports.cshtml"
using login.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"15bcbd22f9fc3d540b1592a8cb5ce8403fcee279", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0b40dcc6b8669af7a98162470d38c362acd51b15", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\user\source\repos\login\login\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
            BeginContext(45, 491, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "64555bbeb89e4b40b5d2cccea907f388", async() => {
                BeginContext(51, 478, true);
                WriteLiteral(@"
    <meta charset=""utf-8"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1, shrink-to-fit=no"">
    <meta name=""description"" content="""">
    <meta name=""author"" content="""">
    <title>4 Col Portfolio - Start Bootstrap Template</title>
    <!-- Bootstrap core CSS -->
    <link href=""vendor/bootstrap/css/bootstrap.min.css"" rel=""stylesheet"">
    <!-- Custom styles for this template -->
    <link href=""css/4-col-portfolio.css"" rel=""stylesheet"">
");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(536, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(538, 8567, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7d45d649489c4001a3c81ff7028e2c51", async() => {
                BeginContext(544, 8554, true);
                WriteLiteral(@"
    <!-- Navigation -->
    <nav class=""navbar navbar-expand-lg navbar-dark bg-dark fixed-top"">
        <div class=""container"">
            <a class=""navbar-brand"" href=""#"">Start Bootstrap</a>
            <button class=""navbar-toggler"" type=""button"" data-toggle=""collapse"" data-target=""#navbarResponsive"" aria-controls=""navbarResponsive"" aria-expanded=""false"" aria-label=""Toggle navigation"">
                <span class=""navbar-toggler-icon""></span>
            </button>
            <div class=""collapse navbar-collapse"" id=""navbarResponsive"">
                <ul class=""navbar-nav ml-auto"">
                    <li class=""nav-item active"">
                        <a class=""nav-link"" href=""#"">
                            Home
                            <span class=""sr-only"">(current)</span>
                        </a>
                    </li>
                    <li class=""nav-item"">
                        <a class=""nav-link"" href=""#"">About</a>
                    </li>
                    <l");
                WriteLiteral(@"i class=""nav-item"">
                        <a class=""nav-link"" href=""#"">Services</a>
                    </li>
                    <li class=""nav-item"">
                        <a class=""nav-link"" href=""#"">Contact</a>
                    </li>
                </ul>
            </div>
        </div>
    </nav>
    <!-- Page Content -->
    <div class=""container"">
        <!-- Page Heading -->
        <h1 class=""my-4"">
            Page Heading
            <small>Secondary Text</small>
        </h1>
        <div class=""row"">
            <div class=""col-lg-3 col-md-4 col-sm-6 portfolio-item"">
                <div class=""card h-100"">
                    <a href=""#""><img class=""card-img-top"" src=""http://placehold.it/700x400"" alt=""""></a>
                    <div class=""card-body"">
                        <h4 class=""card-title"">
                            <a href=""#"">Project One</a>
                        </h4>
                        <p class=""card-text"">Lorem ipsum dolor sit amet, consec");
                WriteLiteral(@"tetur adipisicing elit. Amet numquam aspernatur eum quasi sapiente nesciunt? Voluptatibus sit, repellat sequi itaque deserunt, dolores in, nesciunt, illum tempora ex quae? Nihil, dolorem!</p>
                    </div>
                </div>
            </div>
            <div class=""col-lg-3 col-md-4 col-sm-6 portfolio-item"">
                <div class=""card h-100"">
                    <a href=""#""><img class=""card-img-top"" src=""http://placehold.it/700x400"" alt=""""></a>
                    <div class=""card-body"">
                        <h4 class=""card-title"">
                            <a href=""#"">Project Two</a>
                        </h4>
                        <p class=""card-text"">Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nam viverra euismod odio, gravida pellentesque urna varius vitae.</p>
                    </div>
                </div>
            </div>
            <div class=""col-lg-3 col-md-4 col-sm-6 portfolio-item"">
                <div class=""card h-100"">
     ");
                WriteLiteral(@"               <a href=""#""><img class=""card-img-top"" src=""http://placehold.it/700x400"" alt=""""></a>
                    <div class=""card-body"">
                        <h4 class=""card-title"">
                            <a href=""#"">Project Three</a>
                        </h4>
                        <p class=""card-text"">Lorem ipsum dolor sit amet, consectetur adipisicing elit. Quos quisquam, error quod sed cumque, odio distinctio velit nostrum temporibus necessitatibus et facere atque iure perspiciatis mollitia recusandae vero vel quam!</p>
                    </div>
                </div>
            </div>
            <div class=""col-lg-3 col-md-4 col-sm-6 portfolio-item"">
                <div class=""card h-100"">
                    <a href=""#""><img class=""card-img-top"" src=""http://placehold.it/700x400"" alt=""""></a>
                    <div class=""card-body"">
                        <h4 class=""card-title"">
                            <a href=""#"">Project Four</a>
                        </h4>");
                WriteLiteral(@"
                        <p class=""card-text"">Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nam viverra euismod odio, gravida pellentesque urna varius vitae.</p>
                    </div>
                </div>
            </div>
            <div class=""col-lg-3 col-md-4 col-sm-6 portfolio-item"">
                <div class=""card h-100"">
                    <a href=""#""><img class=""card-img-top"" src=""http://placehold.it/700x400"" alt=""""></a>
                    <div class=""card-body"">
                        <h4 class=""card-title"">
                            <a href=""#"">Project Five</a>
                        </h4>
                        <p class=""card-text"">Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nam viverra euismod odio, gravida pellentesque urna varius vitae.</p>
                    </div>
                </div>
            </div>
            <div class=""col-lg-3 col-md-4 col-sm-6 portfolio-item"">
                <div class=""card h-100"">
                    <a");
                WriteLiteral(@" href=""#""><img class=""card-img-top"" src=""http://placehold.it/700x400"" alt=""""></a>
                    <div class=""card-body"">
                        <h4 class=""card-title"">
                            <a href=""#"">Project Six</a>
                        </h4>
                        <p class=""card-text"">Lorem ipsum dolor sit amet, consectetur adipisicing elit. Itaque earum nostrum suscipit ducimus nihil provident, perferendis rem illo, voluptate atque, sit eius in voluptates, nemo repellat fugiat excepturi! Nemo, esse.</p>
                    </div>
                </div>
            </div>
            <div class=""col-lg-3 col-md-4 col-sm-6 portfolio-item"">
                <div class=""card h-100"">
                    <a href=""#""><img class=""card-img-top"" src=""http://placehold.it/700x400"" alt=""""></a>
                    <div class=""card-body"">
                        <h4 class=""card-title"">
                            <a href=""#"">Project Seven</a>
                        </h4>
                 ");
                WriteLiteral(@"       <p class=""card-text"">Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nam viverra euismod odio, gravida pellentesque urna varius vitae.</p>
                    </div>
                </div>
            </div>
            <div class=""col-lg-3 col-md-4 col-sm-6 portfolio-item"">
                <div class=""card h-100"">
                    <a href=""#""><img class=""card-img-top"" src=""http://placehold.it/700x400"" alt=""""></a>
                    <div class=""card-body"">
                        <h4 class=""card-title"">
                            <a href=""#"">Project Eight</a>
                        </h4>
                        <p class=""card-text"">Lorem ipsum dolor sit amet, consectetur adipisicing elit. Eius adipisci dicta dignissimos neque animi ea, veritatis, provident hic consequatur ut esse! Commodi ea consequatur accusantium, beatae qui deserunt tenetur ipsa.</p>
                    </div>
                </div>
            </div>
        </div>
        <!-- /.row -->
        <!--");
                WriteLiteral(@" Pagination -->
        <ul class=""pagination justify-content-center"">
            <li class=""page-item"">
                <a class=""page-link"" href=""#"" aria-label=""Previous"">
                    <span aria-hidden=""true"">&laquo;</span>
                    <span class=""sr-only"">Previous</span>
                </a>
            </li>
            <li class=""page-item"">
                <a class=""page-link"" href=""#"">1</a>
            </li>
            <li class=""page-item"">
                <a class=""page-link"" href=""#"">2</a>
            </li>
            <li class=""page-item"">
                <a class=""page-link"" href=""#"">3</a>
            </li>
            <li class=""page-item"">
                <a class=""page-link"" href=""#"" aria-label=""Next"">
                    <span aria-hidden=""true"">&raquo;</span>
                    <span class=""sr-only"">Next</span>
                </a>
            </li>
        </ul>
    </div>
    <!-- /.container -->
    <!-- Footer -->
    <footer class=""py-5 bg-");
                WriteLiteral(@"dark"">
        <div class=""container"">
            <p class=""m-0 text-center text-white"">Copyright &copy; Your Website 2018</p>
        </div>
        <!-- /.container -->
    </footer>
    <!-- Bootstrap core JavaScript -->
    <script src=""vendor/jquery/jquery.min.js""></script>
    <script src=""vendor/bootstrap/js/bootstrap.bundle.min.js""></script>
");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(9105, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
