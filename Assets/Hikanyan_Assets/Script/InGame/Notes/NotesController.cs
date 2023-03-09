using Hikanyan.Core;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NotesController : AbstractSingleton<NotesController>
{
    float _blockHeight;
    float _notesSpeed;
    protected override void OnAwake()
    {

    }
    public void SetData(float blockHeight, float notesSpeed)
    {
        _blockHeight = blockHeight;
        _notesSpeed = notesSpeed;
    }

    List<int> _removeNotesByLaneIndex = new();

    void Update()
    {
        if (RealTimer.Instance.IsRunning)
        {
            //MoveNotes();
            //CheckNotesIsNothing();
        }
    }
    //void MoveNotes()
    //{
    //    int i = 0;
    //    for (int blocki = 0; i < 4; blocki++)
    //    {
    //        foreach (Notes notes in NotesManager.instance.blockNotes[blocki])
    //        {
    //            NotesControl(i, notes);
    //        }
    //        i++;
    //    }
    //    if (_removeNotesByLaneIndex.Count > 0)
    //    {
    //        foreach (int temp in _removeNotesByLaneIndex)
    //        {
    //            if (NotesManager.instance.blockNotes[temp].Count <= 0) break;
    //            NotesManager.instance.blockNotes[temp].RemoveAt(0);
    //        }
    //        _removeNotesByLaneIndex.Clear();
    //    }
    //}
}
