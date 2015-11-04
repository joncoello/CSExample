using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Activities;
using System.IO;

namespace CS.Activities
{

    public sealed class EmptyDirectory : CodeActivity
    {
    
        [RequiredArgument]    
        public InArgument<string> DirectoryToEmpty { get; set; }

        
        protected override void Execute(CodeActivityContext context)
        {
            string directoryToEmpty = DirectoryToEmpty.Get(context);
            if (Directory.Exists(directoryToEmpty))
            {
                Directory.EnumerateFiles(directoryToEmpty).ToList().ForEach(f => File.Delete(f));
            }
        }

    }

}
