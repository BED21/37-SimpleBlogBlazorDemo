using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleBlog.Shared
{
    public class CommandResult
    {
        public Dictionary<string, List<string>> Errors { get; set; } = new Dictionary<string, List<string>>();

        public void AddError(string fieldName, string error)
        {
            if (!Errors.ContainsKey(fieldName))
                Errors.Add(fieldName, new List<string>());

            Errors[fieldName].Add(error);
        }

        public bool HasErrors()
        {
            return Errors.Any();
        }
    }
}
