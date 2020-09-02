using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class BuildEditor : MonoBehaviour
{
    public static bool BuildPlayer()
    {
        Debug.Log("Build Player");

        UnityEditor.BuildPlayerOptions buildPlayerOptions = new BuildPlayerOptions();
        buildPlayerOptions.target = BuildTarget.Android;

        var buildReport = BuildPipeline.BuildPlayer(buildPlayerOptions);
        var buildSummary = buildReport.summary;

        return buildSummary.result == UnityEditor.Build.Reporting.BuildResult.Succeeded;
    }
}
