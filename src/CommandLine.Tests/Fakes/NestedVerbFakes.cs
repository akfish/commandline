// Copyright 2005-2013 Giacomo Stelluti Scala & Contributors. All rights reserved. See doc/License.md in the project root for license information.

using System.Collections.Generic;

namespace CommandLine.Tests.Fakes
{
    #region First Level Verbs
    [Verb("account", HelpText = "Manage accounts.")]
    class AccountOptions
    {
        //TODO: what attributes?
        public CreateOptions CreateVerb { get; set; }

        //TODO: what attributes?
        public ListOptions ListVerb { get; set; }
        
        //TODO: what attributes?
        public RemoveOptions RemoveVerb { get; set; }
    }

    [Verb("repo", HelpText = "Manage repositories.")]
    class RepoOptions
    {
        //TODO: what attributes?
        public CreateOptions CreateVerb { get; set; }

        //TODO: what attributes?
        public ListOptions ListVerb { get; set; }

        //TODO: what attributes?
        public RemoveOptions RemoveVerb { get; set; }
    }

    [Verb("archive", HelpText = "Manage archives.")]
    class ArchiveOptions
    {
        //TODO: what attributes?
        public ListOptions ListVerb { get; set; }
    }
    #endregion

    #region Second Level Verbs
    [Verb("create", HelpText = "Create a new entry.")]
    class CreateOptions
    {
        [Value(0)]
        public string Name { get; set; }
    }

    [Verb("list", HelpText = "List all entries.")]
    class ListOptions
    {
    }

    [Verb("remove", HelpText = "Manage files.")]
    class RemoveOptions
    {
        [Value(0)]
        public string Name { get; set; }
    }
    #endregion
}