using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

// Token: 0x0200005A RID: 90
[StructLayout(2)]
public struct TutorialAIStep
{
	// Token: 0x06000CDF RID: 3295 RVA: 0x00040728 File Offset: 0x0003E928
	// Note: this type is marked as 'beforefieldinit'.
	static TutorialAIStep()
	{
		Il2CppClassPointerStore<TutorialAIStep>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "TutorialAIStep");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TutorialAIStep>.NativeClassPtr);
		TutorialAIStep.NativeFieldInfoPtr_selectionHint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialAIStep>.NativeClassPtr, "selectionHint");
		TutorialAIStep.NativeFieldInfoPtr_selectionID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialAIStep>.NativeClassPtr, "selectionID");
		TutorialAIStep.NativeFieldInfoPtr_selectionOptionalData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialAIStep>.NativeClassPtr, "selectionOptionalData");
		TutorialAIStep.NativeFieldInfoPtr_selectionInstanceType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialAIStep>.NativeClassPtr, "selectionInstanceType");
		TutorialAIStep.NativeFieldInfoPtr_selectionInstanceNameHash = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialAIStep>.NativeClassPtr, "selectionInstanceNameHash");
	}

	// Token: 0x06000CE0 RID: 3296 RVA: 0x00009A6B File Offset: 0x00007C6B
	public Object BoxIl2CppObject()
	{
		return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TutorialAIStep>.NativeClassPtr, ref this));
	}

	// Token: 0x0400089E RID: 2206
	private static readonly IntPtr NativeFieldInfoPtr_selectionHint;

	// Token: 0x0400089F RID: 2207
	private static readonly IntPtr NativeFieldInfoPtr_selectionID;

	// Token: 0x040008A0 RID: 2208
	private static readonly IntPtr NativeFieldInfoPtr_selectionOptionalData;

	// Token: 0x040008A1 RID: 2209
	private static readonly IntPtr NativeFieldInfoPtr_selectionInstanceType;

	// Token: 0x040008A2 RID: 2210
	private static readonly IntPtr NativeFieldInfoPtr_selectionInstanceNameHash;

	// Token: 0x040008A3 RID: 2211
	[FieldOffset(0)]
	public ushort selectionHint;

	// Token: 0x040008A4 RID: 2212
	[FieldOffset(2)]
	public ushort selectionID;

	// Token: 0x040008A5 RID: 2213
	[FieldOffset(4)]
	public uint selectionOptionalData;

	// Token: 0x040008A6 RID: 2214
	[FieldOffset(8)]
	public int selectionInstanceType;

	// Token: 0x040008A7 RID: 2215
	[FieldOffset(12)]
	public uint selectionInstanceNameHash;
}
