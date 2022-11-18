#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Hangfire.Dashboard.Pages
{
    
    #line 2 "..\..\Dashboard\Pages\AwaitingJobsPage.cshtml"
    using System;
    
    #line default
    #line hidden
    
    #line 3 "..\..\Dashboard\Pages\AwaitingJobsPage.cshtml"
    using System.Collections.Generic;
    
    #line default
    #line hidden
    using System.Linq;
    using System.Text;
    
    #line 4 "..\..\Dashboard\Pages\AwaitingJobsPage.cshtml"
    using Hangfire;
    
    #line default
    #line hidden
    
    #line 5 "..\..\Dashboard\Pages\AwaitingJobsPage.cshtml"
    using Hangfire.Dashboard;
    
    #line default
    #line hidden
    
    #line 6 "..\..\Dashboard\Pages\AwaitingJobsPage.cshtml"
    using Hangfire.Dashboard.Pages;
    
    #line default
    #line hidden
    
    #line 7 "..\..\Dashboard\Pages\AwaitingJobsPage.cshtml"
    using Hangfire.Dashboard.Resources;
    
    #line default
    #line hidden
    
    #line 8 "..\..\Dashboard\Pages\AwaitingJobsPage.cshtml"
    using Hangfire.States;
    
    #line default
    #line hidden
    
    #line 9 "..\..\Dashboard\Pages\AwaitingJobsPage.cshtml"
    using Hangfire.Storage;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    internal partial class AwaitingJobsPage : RazorPage
    {
#line hidden

        public override void Execute()
        {


WriteLiteral("\r\n");











            
            #line 11 "..\..\Dashboard\Pages\AwaitingJobsPage.cshtml"
  
    Layout = new LayoutPage(Strings.AwaitingJobsPage_Title);

    int from, perPage;

    int.TryParse(Query("from"), out from);
    int.TryParse(Query("count"), out perPage);

    List<string> jobIds = null;
    Pager pager = null;

    using (var connection = Storage.GetConnection())
    {
        var storageConnection = connection as JobStorageConnection;

        if (storageConnection != null)
        {
            pager = new Pager(from, perPage, storageConnection.GetSetCount("awaiting"));
            jobIds = storageConnection.GetRangeFromSet("awaiting", pager.FromRecord, pager.FromRecord + pager.RecordsPerPage - 1);
        }
    }


            
            #line default
            #line hidden
WriteLiteral("\r\n<div class=\"row\">\r\n    <div class=\"col-md-3\">\r\n        ");


            
            #line 36 "..\..\Dashboard\Pages\AwaitingJobsPage.cshtml"
   Write(Html.JobsSidebar());

            
            #line default
            #line hidden
WriteLiteral("\r\n    </div>\r\n    <div class=\"col-md-9\">\r\n        <h1 class=\"page-header\">");


            
            #line 39 "..\..\Dashboard\Pages\AwaitingJobsPage.cshtml"
                           Write(Strings.AwaitingJobsPage_Title);

            
            #line default
            #line hidden
WriteLiteral("</h1>\r\n\r\n");


            
            #line 41 "..\..\Dashboard\Pages\AwaitingJobsPage.cshtml"
         if (jobIds == null)
        {

            
            #line default
            #line hidden
WriteLiteral("            <div class=\"alert alert-warning\">\r\n                <h4>");


            
            #line 44 "..\..\Dashboard\Pages\AwaitingJobsPage.cshtml"
               Write(Strings.AwaitingJobsPage_ContinuationsWarning_Title);

            
            #line default
            #line hidden
WriteLiteral("</h4>\r\n                <p>");


            
            #line 45 "..\..\Dashboard\Pages\AwaitingJobsPage.cshtml"
              Write(Strings.AwaitingJobsPage_ContinuationsWarning_Text);

            
            #line default
            #line hidden
WriteLiteral("</p>\r\n            </div>\r\n");


            
            #line 47 "..\..\Dashboard\Pages\AwaitingJobsPage.cshtml"
        }
        else if (jobIds.Count > 0)
        {

            
            #line default
            #line hidden
WriteLiteral("            <div class=\"js-jobs-list\">\r\n                <div class=\"btn-toolbar b" +
"tn-toolbar-top\">\r\n");


            
            #line 52 "..\..\Dashboard\Pages\AwaitingJobsPage.cshtml"
                     if (!IsReadOnly)
                    {

            
            #line default
            #line hidden
WriteLiteral("                        <button class=\"js-jobs-list-command btn btn-sm btn-primar" +
"y\"\r\n                                data-url=\"");


            
            #line 55 "..\..\Dashboard\Pages\AwaitingJobsPage.cshtml"
                                     Write(Url.To("/jobs/awaiting/enqueue"));

            
            #line default
            #line hidden
WriteLiteral("\"\r\n                                data-loading-text=\"");


            
            #line 56 "..\..\Dashboard\Pages\AwaitingJobsPage.cshtml"
                                              Write(Strings.Common_Enqueueing);

            
            #line default
            #line hidden
WriteLiteral("\">\r\n                            <span class=\"glyphicon glyphicon-repeat\"></span>\r" +
"\n                            ");


            
            #line 58 "..\..\Dashboard\Pages\AwaitingJobsPage.cshtml"
                       Write(Strings.Common_EnqueueButton_Text);

            
            #line default
            #line hidden
WriteLiteral("\r\n                        </button>\r\n");


            
            #line 60 "..\..\Dashboard\Pages\AwaitingJobsPage.cshtml"
                    }

            
            #line default
            #line hidden

            
            #line 61 "..\..\Dashboard\Pages\AwaitingJobsPage.cshtml"
                     if (!IsReadOnly)
                    {

            
            #line default
            #line hidden
WriteLiteral("                        <button class=\"js-jobs-list-command btn btn-sm btn-defaul" +
"t\"\r\n                                data-url=\"");


            
            #line 64 "..\..\Dashboard\Pages\AwaitingJobsPage.cshtml"
                                     Write(Url.To("/jobs/awaiting/delete"));

            
            #line default
            #line hidden
WriteLiteral("\"\r\n                                data-loading-text=\"");


            
            #line 65 "..\..\Dashboard\Pages\AwaitingJobsPage.cshtml"
                                              Write(Strings.Common_Deleting);

            
            #line default
            #line hidden
WriteLiteral("\"\r\n                                data-confirm=\"");


            
            #line 66 "..\..\Dashboard\Pages\AwaitingJobsPage.cshtml"
                                         Write(Strings.Common_DeleteConfirm);

            
            #line default
            #line hidden
WriteLiteral("\">\r\n                            <span class=\"glyphicon glyphicon-remove\"></span>\r" +
"\n                            ");


            
            #line 68 "..\..\Dashboard\Pages\AwaitingJobsPage.cshtml"
                       Write(Strings.Common_DeleteSelected);

            
            #line default
            #line hidden
WriteLiteral("\r\n                        </button>\r\n");


            
            #line 70 "..\..\Dashboard\Pages\AwaitingJobsPage.cshtml"
                    }

            
            #line default
            #line hidden
WriteLiteral("                    ");


            
            #line 71 "..\..\Dashboard\Pages\AwaitingJobsPage.cshtml"
               Write(Html.PerPageSelector(pager));

            
            #line default
            #line hidden
WriteLiteral("\r\n                </div>\r\n\r\n                <div class=\"table-responsive\">\r\n     " +
"               <table class=\"table table-hover\">\r\n                        <thead" +
">\r\n                            <tr>\r\n");


            
            #line 78 "..\..\Dashboard\Pages\AwaitingJobsPage.cshtml"
                                 if (!IsReadOnly)
                                {

            
            #line default
            #line hidden
WriteLiteral("                                    <th class=\"min-width\">\r\n                     " +
"                   <input type=\"checkbox\" class=\"js-jobs-list-select-all\"/>\r\n   " +
"                                 </th>\r\n");


            
            #line 83 "..\..\Dashboard\Pages\AwaitingJobsPage.cshtml"
                                }

            
            #line default
            #line hidden
WriteLiteral("                                <th class=\"min-width\">");


            
            #line 84 "..\..\Dashboard\Pages\AwaitingJobsPage.cshtml"
                                                 Write(Strings.Common_Id);

            
            #line default
            #line hidden
WriteLiteral("</th>\r\n                                <th>");


            
            #line 85 "..\..\Dashboard\Pages\AwaitingJobsPage.cshtml"
                               Write(Strings.Common_Job);

            
            #line default
            #line hidden
WriteLiteral("</th>\r\n                                <th class=\"min-width\">");


            
            #line 86 "..\..\Dashboard\Pages\AwaitingJobsPage.cshtml"
                                                 Write(Strings.AwaitingJobsPage_Table_Options);

            
            #line default
            #line hidden
WriteLiteral("</th>\r\n                                <th class=\"min-width\">");


            
            #line 87 "..\..\Dashboard\Pages\AwaitingJobsPage.cshtml"
                                                 Write(Strings.AwaitingJobsPage_Table_Parent);

            
            #line default
            #line hidden
WriteLiteral("</th>\r\n                                <th class=\"align-right\">");


            
            #line 88 "..\..\Dashboard\Pages\AwaitingJobsPage.cshtml"
                                                   Write(Strings.Common_Created);

            
            #line default
            #line hidden
WriteLiteral("</th>\r\n                            </tr>\r\n                        </thead>\r\n     " +
"                   <tbody>\r\n");


            
            #line 92 "..\..\Dashboard\Pages\AwaitingJobsPage.cshtml"
                             foreach (var jobId in jobIds)
                            {
                                JobData jobData;
                                StateData stateData;
                                StateData parentStateData = null;

                                using (var connection = Storage.GetConnection())
                                {
                                    jobData = connection.GetJobData(jobId);
                                    stateData = connection.GetStateData(jobId);

                                    if (stateData != null && stateData.Name == AwaitingState.StateName)
                                    {
                                        parentStateData = connection.GetStateData(stateData.Data["ParentId"]);
                                    }
                                }


            
            #line default
            #line hidden
WriteLiteral("                                <tr class=\"js-jobs-list-row ");


            
            #line 109 "..\..\Dashboard\Pages\AwaitingJobsPage.cshtml"
                                                        Write(jobData != null ? "hover" : null);

            
            #line default
            #line hidden
WriteLiteral("\">\r\n");


            
            #line 110 "..\..\Dashboard\Pages\AwaitingJobsPage.cshtml"
                                     if (!IsReadOnly)
                                    {

            
            #line default
            #line hidden
WriteLiteral("                                        <td>\r\n                                   " +
"         <input type=\"checkbox\" class=\"js-jobs-list-checkbox\" name=\"jobs[]\" valu" +
"e=\"");


            
            #line 113 "..\..\Dashboard\Pages\AwaitingJobsPage.cshtml"
                                                                                                                 Write(jobId);

            
            #line default
            #line hidden
WriteLiteral("\"/>\r\n                                        </td>\r\n");


            
            #line 115 "..\..\Dashboard\Pages\AwaitingJobsPage.cshtml"
                                    }

            
            #line default
            #line hidden
WriteLiteral("                                    <td class=\"min-width\">\r\n                     " +
"                   ");


            
            #line 117 "..\..\Dashboard\Pages\AwaitingJobsPage.cshtml"
                                   Write(Html.JobIdLink(jobId));

            
            #line default
            #line hidden
WriteLiteral("\r\n                                    </td>\r\n");


            
            #line 119 "..\..\Dashboard\Pages\AwaitingJobsPage.cshtml"
                                     if (jobData == null)
                                    {

            
            #line default
            #line hidden
WriteLiteral("                                        <td colspan=\"2\"><em>");


            
            #line 121 "..\..\Dashboard\Pages\AwaitingJobsPage.cshtml"
                                                       Write(Strings.Common_JobExpired);

            
            #line default
            #line hidden
WriteLiteral("</em></td>\r\n");


            
            #line 122 "..\..\Dashboard\Pages\AwaitingJobsPage.cshtml"
                                    }
                                    else
                                    {

            
            #line default
            #line hidden
WriteLiteral("                                        <td class=\"word-break\">\r\n                " +
"                            ");


            
            #line 126 "..\..\Dashboard\Pages\AwaitingJobsPage.cshtml"
                                       Write(Html.JobNameLink(jobId, jobData.Job));

            
            #line default
            #line hidden
WriteLiteral("\r\n                                        </td>\r\n");



WriteLiteral("                                        <td class=\"min-width\">\r\n");


            
            #line 129 "..\..\Dashboard\Pages\AwaitingJobsPage.cshtml"
                                             if (stateData != null && stateData.Data.ContainsKey("Options") && !String.IsNullOrWhiteSpace(stateData.Data["Options"]))
                                            {
                                                var optionsDescription = stateData.Data["Options"];
                                                if (Enum.TryParse(optionsDescription, out JobContinuationOptions options))
                                                {
                                                    optionsDescription = options.ToString("G");
                                                }

            
            #line default
            #line hidden
WriteLiteral("                                                <code>");


            
            #line 136 "..\..\Dashboard\Pages\AwaitingJobsPage.cshtml"
                                                 Write(optionsDescription);

            
            #line default
            #line hidden
WriteLiteral("</code>\r\n");


            
            #line 137 "..\..\Dashboard\Pages\AwaitingJobsPage.cshtml"
                                            }
                                            else
                                            {

            
            #line default
            #line hidden
WriteLiteral("                                                <em>");


            
            #line 140 "..\..\Dashboard\Pages\AwaitingJobsPage.cshtml"
                                               Write(Strings.Common_NotAvailable);

            
            #line default
            #line hidden
WriteLiteral("</em>\r\n");


            
            #line 141 "..\..\Dashboard\Pages\AwaitingJobsPage.cshtml"
                                            }

            
            #line default
            #line hidden
WriteLiteral("                                        </td>\r\n");



WriteLiteral("                                        <td class=\"min-width\">\r\n");


            
            #line 144 "..\..\Dashboard\Pages\AwaitingJobsPage.cshtml"
                                             if (parentStateData != null)
                                            {

            
            #line default
            #line hidden
WriteLiteral("                                                <a href=\"");


            
            #line 146 "..\..\Dashboard\Pages\AwaitingJobsPage.cshtml"
                                                    Write(Url.JobDetails(stateData.Data["ParentId"]));

            
            #line default
            #line hidden
WriteLiteral("\" class=\"text-decoration-none\">\r\n                                                " +
"    ");


            
            #line 147 "..\..\Dashboard\Pages\AwaitingJobsPage.cshtml"
                                               Write(Html.StateLabel(parentStateData.Name, parentStateData.Name, hover: true));

            
            #line default
            #line hidden
WriteLiteral("\r\n                                                </a>\r\n");


            
            #line 149 "..\..\Dashboard\Pages\AwaitingJobsPage.cshtml"
                                            }
                                            else
                                            {

            
            #line default
            #line hidden
WriteLiteral("                                                <em>");


            
            #line 152 "..\..\Dashboard\Pages\AwaitingJobsPage.cshtml"
                                               Write(Strings.Common_NotAvailable);

            
            #line default
            #line hidden
WriteLiteral("</em>\r\n");


            
            #line 153 "..\..\Dashboard\Pages\AwaitingJobsPage.cshtml"
                                            }

            
            #line default
            #line hidden
WriteLiteral("                                        </td>\r\n");



WriteLiteral("                                        <td class=\"min-width align-right\">\r\n     " +
"                                       ");


            
            #line 156 "..\..\Dashboard\Pages\AwaitingJobsPage.cshtml"
                                       Write(Html.RelativeTime(jobData.CreatedAt));

            
            #line default
            #line hidden
WriteLiteral("\r\n                                        </td>\r\n");


            
            #line 158 "..\..\Dashboard\Pages\AwaitingJobsPage.cshtml"
                                    }

            
            #line default
            #line hidden
WriteLiteral("                                </tr>\r\n");


            
            #line 160 "..\..\Dashboard\Pages\AwaitingJobsPage.cshtml"
                            }

            
            #line default
            #line hidden
WriteLiteral("                        </tbody>\r\n                    </table>\r\n                <" +
"/div>\r\n                ");


            
            #line 164 "..\..\Dashboard\Pages\AwaitingJobsPage.cshtml"
           Write(Html.Paginator(pager));

            
            #line default
            #line hidden
WriteLiteral("\r\n            </div>\r\n");


            
            #line 166 "..\..\Dashboard\Pages\AwaitingJobsPage.cshtml"
        }
        else
        {

            
            #line default
            #line hidden
WriteLiteral("            <div class=\"alert alert-info\">\r\n                ");


            
            #line 170 "..\..\Dashboard\Pages\AwaitingJobsPage.cshtml"
           Write(Strings.AwaitingJobsPage_NoJobs);

            
            #line default
            #line hidden
WriteLiteral("\r\n            </div>\r\n");


            
            #line 172 "..\..\Dashboard\Pages\AwaitingJobsPage.cshtml"
        }

            
            #line default
            #line hidden
WriteLiteral("    </div>\r\n</div>\r\n");


        }
    }
}
#pragma warning restore 1591
