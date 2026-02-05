using AuthService2021547.Api.Models;
using AuthService2021547.Application.Interface;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace AuthService2021547.Api.ModelBinders;

public class FileDataModelBinder : IModelBiner
{
    
    public Task BinModelAsync(ModelBindigContext bindigContext)
    {
        ArgumentNullException.ThrowIfNull(bindigContext);
        if (!typeof(IFileData).IsAssignableFrom(bindigContext.ModelType))
        {
            return Task.CompletedTask;
        }

        var request = bindigContext.HttpContext.Request;

        var file = request.From.Files.GetFile(bindigContext.FileName);

        if(file != null && file.Length > 0)
        {
            var fileData = new FormFileAdapter(file);
            bindigContext.Result = ModelBindingResult.Sucess(null);
        }
        else
        {
            bendingContext.Result = ModelBindingResult.Sucess(null);
        }

        return Task.CompletedTask;
    }
}

public class FileDataModelBinderProvider : IModelBinderProvider
{
    public IModelBinder? GetBinder (ModelBinderProviderContext context)
    {
        if (typeof(IFileData).IsAssignableFrom(context.Metadata.ModelType))
        {
            return new FileDataModelBinder();
        }

        return null;
    }
}