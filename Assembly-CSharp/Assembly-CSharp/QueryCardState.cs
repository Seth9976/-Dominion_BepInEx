using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

// Token: 0x02000054 RID: 84
[StructLayout(2)]
public struct QueryCardState
{
	// Token: 0x06000CD7 RID: 3287 RVA: 0x00040514 File Offset: 0x0003E714
	// Note: this type is marked as 'beforefieldinit'.
	static QueryCardState()
	{
		Il2CppClassPointerStore<QueryCardState>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "QueryCardState");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<QueryCardState>.NativeClassPtr);
		QueryCardState.NativeFieldInfoPtr_cardInstanceID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QueryCardState>.NativeClassPtr, "cardInstanceID");
		QueryCardState.NativeFieldInfoPtr_cardLocation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QueryCardState>.NativeClassPtr, "cardLocation");
		QueryCardState.NativeFieldInfoPtr_cardRuneCostBase = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QueryCardState>.NativeClassPtr, "cardRuneCostBase");
		QueryCardState.NativeFieldInfoPtr_cardRuneCostAdjusted = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QueryCardState>.NativeClassPtr, "cardRuneCostAdjusted");
		QueryCardState.NativeFieldInfoPtr_cardPowerCostBase = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QueryCardState>.NativeClassPtr, "cardPowerCostBase");
		QueryCardState.NativeFieldInfoPtr_cardPowerCostAdjusted = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QueryCardState>.NativeClassPtr, "cardPowerCostAdjusted");
		QueryCardState.NativeFieldInfoPtr_cardInsightCostBase = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QueryCardState>.NativeClassPtr, "cardInsightCostBase");
		QueryCardState.NativeFieldInfoPtr_cardInsightCostAdjusted = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QueryCardState>.NativeClassPtr, "cardInsightCostAdjusted");
		QueryCardState.NativeFieldInfoPtr_cardSelectableDataFlags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QueryCardState>.NativeClassPtr, "cardSelectableDataFlags");
		QueryCardState.NativeFieldInfoPtr_cardAdditionalFactionFlags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QueryCardState>.NativeClassPtr, "cardAdditionalFactionFlags");
	}

	// Token: 0x06000CD8 RID: 3288 RVA: 0x00009A23 File Offset: 0x00007C23
	public Object BoxIl2CppObject()
	{
		return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<QueryCardState>.NativeClassPtr, ref this));
	}

	// Token: 0x04000864 RID: 2148
	private static readonly IntPtr NativeFieldInfoPtr_cardInstanceID;

	// Token: 0x04000865 RID: 2149
	private static readonly IntPtr NativeFieldInfoPtr_cardLocation;

	// Token: 0x04000866 RID: 2150
	private static readonly IntPtr NativeFieldInfoPtr_cardRuneCostBase;

	// Token: 0x04000867 RID: 2151
	private static readonly IntPtr NativeFieldInfoPtr_cardRuneCostAdjusted;

	// Token: 0x04000868 RID: 2152
	private static readonly IntPtr NativeFieldInfoPtr_cardPowerCostBase;

	// Token: 0x04000869 RID: 2153
	private static readonly IntPtr NativeFieldInfoPtr_cardPowerCostAdjusted;

	// Token: 0x0400086A RID: 2154
	private static readonly IntPtr NativeFieldInfoPtr_cardInsightCostBase;

	// Token: 0x0400086B RID: 2155
	private static readonly IntPtr NativeFieldInfoPtr_cardInsightCostAdjusted;

	// Token: 0x0400086C RID: 2156
	private static readonly IntPtr NativeFieldInfoPtr_cardSelectableDataFlags;

	// Token: 0x0400086D RID: 2157
	private static readonly IntPtr NativeFieldInfoPtr_cardAdditionalFactionFlags;

	// Token: 0x0400086E RID: 2158
	[FieldOffset(0)]
	public uint cardInstanceID;

	// Token: 0x0400086F RID: 2159
	[FieldOffset(4)]
	public uint cardLocation;

	// Token: 0x04000870 RID: 2160
	[FieldOffset(8)]
	public uint cardRuneCostBase;

	// Token: 0x04000871 RID: 2161
	[FieldOffset(12)]
	public uint cardRuneCostAdjusted;

	// Token: 0x04000872 RID: 2162
	[FieldOffset(16)]
	public uint cardPowerCostBase;

	// Token: 0x04000873 RID: 2163
	[FieldOffset(20)]
	public uint cardPowerCostAdjusted;

	// Token: 0x04000874 RID: 2164
	[FieldOffset(24)]
	public uint cardInsightCostBase;

	// Token: 0x04000875 RID: 2165
	[FieldOffset(28)]
	public uint cardInsightCostAdjusted;

	// Token: 0x04000876 RID: 2166
	[FieldOffset(32)]
	public ushort cardSelectableDataFlags;

	// Token: 0x04000877 RID: 2167
	[FieldOffset(36)]
	public uint cardAdditionalFactionFlags;
}
