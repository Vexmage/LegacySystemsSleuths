using LegacySystemsSleuths.Models;

namespace LegacySystemsSleuths.Data;

public static class SiteContent
{
    public static List<ServiceOffering> Services =
    [
        new()
        {
            Title = "Infrastructure Investigation",
            Description = "We inspect the strange machinery behind your organization’s daily operations.",
            Bullets =
            [
                "Network audits",
                "DNS troubleshooting",
                "Active Directory issues",
                "Samba deployments",
                "Authentication problems"
            ]
        },
        new()
        {
            Title = "Legacy System Rescue",
            Description = "For systems that still run because everyone is afraid to touch them.",
            Bullets =
            [
                "Unsupported applications",
                "Aging servers",
                "Migration planning",
                "Documentation recovery"
            ]
        },
        new()
        {
            Title = "Website and Hosting Forensics",
            Description = "Domains, hosting, email, and WordPress mysteries examined with a lantern and a packet sniffer.",
            Bullets =
            [
                "WordPress recovery",
                "Domain and DNS problems",
                "Email delivery issues",
                "Hosting migrations"
            ]
        },
        new()
        {
            Title = "Technical Archaeology",
            Description = "We reconstruct what happened before recommending what should happen next.",
            Bullets =
            [
                "Reverse engineering workflows",
                "Understanding undocumented systems",
                "Identifying technical debt",
                "Reconstructing system history"
            ]
        }
    ];

    public static List<CaseFile> CaseFiles =
    [
        new()
        {
            Title = "The Case of the Missing Domain Controller",
            Severity = "Technically Haunted",
            Symptoms = ["Authentication failures", "Mysterious DNS behavior"],
            Outcomes = ["Root cause identified", "Infrastructure documented"]
        },
        new()
        {
            Title = "The Haunted DNS Configuration",
            Severity = "Concerning",
            Symptoms = ["Website intermittently unavailable", "Old records pointing into the void"],
            Outcomes = ["Legacy records removed", "Services stabilized"]
        },
        new()
        {
            Title = "The Curious Incident of the Spreadsheet That Runs Payroll",
            Severity = "Call Us Immediately",
            Symptoms = ["Critical business process controlled by one spreadsheet"],
            Outcomes = ["Workflow documented", "Risk assessment completed"]
        },
        new()
        {
            Title = "The Developer Who Vanished in 2019",
            Severity = "Suspicious",
            Symptoms = ["No documentation", "No source control"],
            Outcomes = ["System reverse engineered", "Maintenance plan created"]
        }
    ];

    public static List<ProcessStepModel> ProcessSteps =
    [
        new() { Number = 1, Title = "Investigate", Description = "We gather clues, inspect logs, interview stakeholders, and determine what the system thinks it is doing." },
        new() { Number = 2, Title = "Document", Description = "We turn tribal knowledge, panic notes, and forgotten configuration files into usable documentation." },
        new() { Number = 3, Title = "Stabilize", Description = "We reduce immediate risk and stop the system from behaving like a cursed artifact." },
        new() { Number = 4, Title = "Modernize", Description = "Only after understanding the system do we recommend upgrades, migrations, or replacements." }
    ];

    public static List<MysteryCounter> Counters =
    [
        new() { Label = "DNS Mysteries Solved", Count = 47 },
        new() { Label = "Legacy Systems Rescued", Count = 23 },
        new() { Label = "Documentation Recovered", Count = 118 },
        new() { Label = "Developers Located", Count = 3 }
    ];
}