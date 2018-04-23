using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Upload.Helpers {
    public class SaveFilesHelper {
        public static void Save(HttpContextBase context) {
            try {
                HttpFileCollectionBase files = context.Request.Files;
                HttpRequestBase request = context.Request;
                if (files.Count != 0) {
                    for (int i = 0; i < files.Count; i++) {
                        HttpPostedFileBase file = files[i];
                        if (file.ContentLength != 0) {
                            string fileName = string.Empty;
                            if (request.Browser.Browser.Contains("InternetExplorer"))
                                fileName = System.IO.Path.GetFileName(file.FileName);
                            else
                                fileName = file.FileName;
                            string path = context.Server.MapPath("~/Images/") + fileName;
                            file.SaveAs(path);
                        }
                    }
                }
            } catch (Exception ex) {
                context.Response.Write(ex.Message);
            }
        }
    }
}