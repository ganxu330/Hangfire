﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18052
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HangFire.Web.Pages
{
    
    #line 2 "..\..\Pages\EnqueuedJobsPage.cshtml"
    using System;
    
    #line default
    #line hidden
    
    #line 3 "..\..\Pages\EnqueuedJobsPage.cshtml"
    using System.Collections.Generic;
    
    #line default
    #line hidden
    
    #line 4 "..\..\Pages\EnqueuedJobsPage.cshtml"
    using System.Linq;
    
    #line default
    #line hidden
    using System.Text;
    
    #line 5 "..\..\Pages\EnqueuedJobsPage.cshtml"
    using Pages;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    internal partial class EnqueuedJobsPage : RazorPage
    {
#line hidden

        public override void Execute()
        {


WriteLiteral("\r\n");







            
            #line 7 "..\..\Pages\EnqueuedJobsPage.cshtml"
  
    Layout = new LayoutPage
        {
            Title = QueueName, 
            Subtitle = "Enqueued jobs",
            Breadcrumbs = new Dictionary<string, string>
                {
                    { "Queues", Request.LinkTo("/queues") }
                }
        };

    int from, perPage;

    int.TryParse(Request.QueryString["from"], out from);
    int.TryParse(Request.QueryString["count"], out perPage);

    var pager = new Pager(from, perPage, JobStorage.EnqueuedCount(QueueName))
    {
        BaseLink = Request.LinkTo("/queues/" + QueueName)
    };

    var enqueuedJobs = JobStorage.EnqueuedJobs(QueueName, pager.From, pager.PerPage);


            
            #line default
            #line hidden
WriteLiteral("\r\n");


            
            #line 31 "..\..\Pages\EnqueuedJobsPage.cshtml"
 if (pager.TotalPages == 0)
{

            
            #line default
            #line hidden
WriteLiteral("    <div class=\"alert alert-info\">\r\n        Queue is empty\r\n    </div>\r\n");


            
            #line 36 "..\..\Pages\EnqueuedJobsPage.cshtml"
}
else
{

            
            #line default
            #line hidden
WriteLiteral("    <div class=\"btn-toolbar btn-toolbar-top\">\r\n        <div class=\"btn-group pull" +
"-right paginator\">\r\n");


            
            #line 41 "..\..\Pages\EnqueuedJobsPage.cshtml"
             foreach (var count in new[] { 10, 20, 50, 100 })
            {

            
            #line default
            #line hidden
WriteLiteral("                <a class=\"btn btn-default ");


            
            #line 43 "..\..\Pages\EnqueuedJobsPage.cshtml"
                                      Write(count == pager.PerPage ? "active" : null);

            
            #line default
            #line hidden
WriteLiteral("\" \r\n                    href=\"");


            
            #line 44 "..\..\Pages\EnqueuedJobsPage.cshtml"
                     Write(pager.PerPageLink(count));

            
            #line default
            #line hidden
WriteLiteral("\">");


            
            #line 44 "..\..\Pages\EnqueuedJobsPage.cshtml"
                                                Write(count);

            
            #line default
            #line hidden
WriteLiteral("</a>    \r\n");


            
            #line 45 "..\..\Pages\EnqueuedJobsPage.cshtml"
            }

            
            #line default
            #line hidden
WriteLiteral("        </div>\r\n        <div class=\"btn-group pull-right\">\r\n            <span cla" +
"ss=\"btn\">Jobs per page:</span>\r\n        </div>\r\n    </div>\r\n");


            
            #line 51 "..\..\Pages\EnqueuedJobsPage.cshtml"
    

            
            #line default
            #line hidden
WriteLiteral("    <table class=\"table\">\r\n        <thead>\r\n            <tr>\r\n                <th" +
">Id</th>\r\n                <th>Type</th>\r\n                <th>Args</th>\r\n        " +
"        <th>Enqueued At</th>\r\n            </tr>\r\n        </thead>\r\n        <tbod" +
"y>\r\n");


            
            #line 62 "..\..\Pages\EnqueuedJobsPage.cshtml"
             foreach (var job in enqueuedJobs)
            {

            
            #line default
            #line hidden
WriteLiteral("                <tr>\r\n                    <td><a href=\"");


            
            #line 65 "..\..\Pages\EnqueuedJobsPage.cshtml"
                            Write(Request.LinkTo("/job/" + job.Key));

            
            #line default
            #line hidden
WriteLiteral("\">");


            
            #line 65 "..\..\Pages\EnqueuedJobsPage.cshtml"
                                                                Write(HtmlHelper.JobId(job.Key));

            
            #line default
            #line hidden
WriteLiteral("</a></td>\r\n                    <td>");


            
            #line 66 "..\..\Pages\EnqueuedJobsPage.cshtml"
                   Write(HtmlHelper.JobType(job.Value.Type));

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n                    <td><code>\r\n                            ");


            
            #line 68 "..\..\Pages\EnqueuedJobsPage.cshtml"
                       Write(HtmlHelper.FormatProperties(job.Value.Args));

            
            #line default
            #line hidden
WriteLiteral("\r\n                        </code></td>\r\n                    <td data-moment=\"");


            
            #line 70 "..\..\Pages\EnqueuedJobsPage.cshtml"
                                Write(JobHelper.ToStringTimestamp(job.Value.EnqueuedAt));

            
            #line default
            #line hidden
WriteLiteral("\">");


            
            #line 70 "..\..\Pages\EnqueuedJobsPage.cshtml"
                                                                                    Write(job.Value.EnqueuedAt);

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n                </tr>\r\n");


            
            #line 72 "..\..\Pages\EnqueuedJobsPage.cshtml"
            }

            
            #line default
            #line hidden
WriteLiteral("        </tbody>\r\n    </table>\r\n");


            
            #line 75 "..\..\Pages\EnqueuedJobsPage.cshtml"
    

            
            #line default
            #line hidden
WriteLiteral("    <div class=\"btn-toolbar\">\r\n");


            
            #line 77 "..\..\Pages\EnqueuedJobsPage.cshtml"
         if (pager.TotalPages > 1)
        {

            
            #line default
            #line hidden
WriteLiteral("            <div class=\"btn-group paginator\">\r\n                <a href=\"");


            
            #line 80 "..\..\Pages\EnqueuedJobsPage.cshtml"
                    Write(pager.PreviousPageLink);

            
            #line default
            #line hidden
WriteLiteral("\" \r\n                   class=\"btn btn-default ");


            
            #line 81 "..\..\Pages\EnqueuedJobsPage.cshtml"
                                      Write(!pager.HasPreviousPage ? "disabled" : null);

            
            #line default
            #line hidden
WriteLiteral("\">&laquo;</a>\r\n\r\n");


            
            #line 83 "..\..\Pages\EnqueuedJobsPage.cshtml"
                 for (var i = 1; i <= pager.TotalPages; i++)
                {

            
            #line default
            #line hidden
WriteLiteral("                    <a class=\"btn btn-default ");


            
            #line 85 "..\..\Pages\EnqueuedJobsPage.cshtml"
                                          Write(pager.CurrentPage == i ? "active" : null);

            
            #line default
            #line hidden
WriteLiteral("\" \r\n                       href=\"");


            
            #line 86 "..\..\Pages\EnqueuedJobsPage.cshtml"
                        Write(pager.PageLink(i));

            
            #line default
            #line hidden
WriteLiteral("\">");


            
            #line 86 "..\..\Pages\EnqueuedJobsPage.cshtml"
                                            Write(i);

            
            #line default
            #line hidden
WriteLiteral("</a>\r\n");


            
            #line 87 "..\..\Pages\EnqueuedJobsPage.cshtml"
                }

            
            #line default
            #line hidden
WriteLiteral("\r\n                <a href=\"");


            
            #line 89 "..\..\Pages\EnqueuedJobsPage.cshtml"
                    Write(pager.NextPageLink);

            
            #line default
            #line hidden
WriteLiteral("\" \r\n                   class=\"btn btn-default ");


            
            #line 90 "..\..\Pages\EnqueuedJobsPage.cshtml"
                                      Write(!pager.HasNextPage ? "disabled" : null);

            
            #line default
            #line hidden
WriteLiteral("\">&raquo;</a>\r\n            </div>\r\n");


            
            #line 92 "..\..\Pages\EnqueuedJobsPage.cshtml"
        }

            
            #line default
            #line hidden
WriteLiteral("\r\n        <div class=\"btn-group\">\r\n            <span class=\"btn\">Total jobs: ");


            
            #line 95 "..\..\Pages\EnqueuedJobsPage.cshtml"
                                     Write(pager.Total);

            
            #line default
            #line hidden
WriteLiteral("</span>\r\n        </div>\r\n    </div>\r\n");


            
            #line 98 "..\..\Pages\EnqueuedJobsPage.cshtml"
}
            
            #line default
            #line hidden

        }
    }
}
#pragma warning restore 1591
