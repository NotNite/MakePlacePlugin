﻿// Decompiled with JetBrains decompiler
// Type: MakePlacePlugin.LayoutWorld
// Assembly: MakePlacePlugin, Version=3.2.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 33141E60-60A1-49AF-9070-B7E7DF8090BB
// Assembly location: C:\Users\Julian\Downloads\MakePlace\MakePlacePlugin.dll

using System.Runtime.InteropServices;

namespace MakePlacePlugin; 

[StructLayout(LayoutKind.Explicit)]
public struct LayoutWorld {
    [FieldOffset(32)] public unsafe LayoutManager* ActiveLayout;
    [FieldOffset(64)] public unsafe HousingStructure* HousingStruct;
}