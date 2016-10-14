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
        public InArgument<string> DirectoryToEmptyZ { get; set; }

        
        protected override void Execute(CodeActivityContext context)
        {
            string directoryToEmpty = DirectoryToEmptyZ.Get(context);
            if (Directory.Exists(directoryToEmpty))
            {
                Directory.EnumerateFiles(directoryToEmpty).ToList().ForEach(f => File.Delete(f));
            }
        }

    }

}
