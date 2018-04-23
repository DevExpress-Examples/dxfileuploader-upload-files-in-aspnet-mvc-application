AJAX Uploading:
<div id="uploadContainer"></div>

Form Submit Uploading:
@Using (Html.BeginForm("Submit", "Home", FormMethod.Post, New With {.enctype = "multipart/form-data"}))
    @<div id="formUploadContainer"></div>
    @<input type="submit" />
End Using

<script type="text/javascript">
    $("#uploadContainer").dxFileUploader({
        buttonText: 'Select file',
        labelText: 'Drop file here',
        multiple: true,
        accept: 'image/*',
        uploadUrl: '@Url.Action("FileUpload", "Home")'
    });

    $("#formUploadContainer").dxFileUploader({
        buttonText: 'Select file',
        labelText: 'Drop file here',
        multiple: true,
        accept: 'image/*',
        uploadMode: 'useForm'
    });
</script>