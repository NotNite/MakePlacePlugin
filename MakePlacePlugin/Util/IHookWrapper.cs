﻿// Decompiled with JetBrains decompiler
// Type: MakePlacePlugin.IHookWrapper
// Assembly: MakePlacePlugin, Version=3.2.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 33141E60-60A1-49AF-9070-B7E7DF8090BB
// Assembly location: C:\Users\Julian\Downloads\MakePlace\MakePlacePlugin.dll

using System;

namespace MakePlacePlugin; 

public interface IHookWrapper : IDisposable {
    bool IsEnabled { get; }

    bool IsDisposed { get; }

    void Enable();

    void Disable();
}