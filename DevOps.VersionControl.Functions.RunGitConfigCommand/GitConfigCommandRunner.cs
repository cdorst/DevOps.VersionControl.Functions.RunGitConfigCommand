using static DevOps.VersionControl.Functions.RunGitCommand.GitCommandRunner;

namespace DevOps.VersionControl.Functions.RunGitConfigCommand
{
    public static class GitConfigCommandRunner
    {
        private const string config = nameof(config);

        public static void Config(string directory, string key, string value)
            => Git(directory,
                command: config,
                key,
                value);
    }
}
