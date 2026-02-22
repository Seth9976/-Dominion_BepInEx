using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

// Token: 0x02000144 RID: 324
public static class SA_EditorTesting : Object
{
	// Token: 0x060017E7 RID: 6119 RVA: 0x00069550 File Offset: 0x00067750
	// Note: this type is marked as 'beforefieldinit'.
	static SA_EditorTesting()
	{
		Il2CppClassPointerStore<SA_EditorTesting>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "SA_EditorTesting");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SA_EditorTesting>.NativeClassPtr);
		SA_EditorTesting.NativeFieldInfoPtr_DEFAULT_SORT_ORDER = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SA_EditorTesting>.NativeClassPtr, "DEFAULT_SORT_ORDER");
		SA_EditorTesting.NativeMethodInfoPtr_get_IsInsideEditor_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_EditorTesting>.NativeClassPtr, 100666197);
		SA_EditorTesting.NativeMethodInfoPtr_HasFill_Public_Static_Boolean_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_EditorTesting>.NativeClassPtr, 100666198);
		SA_EditorTesting.NativeMethodInfoPtr_CheckForEventSystem_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_EditorTesting>.NativeClassPtr, 100666199);
	}

	// Token: 0x170006BC RID: 1724
	// (get) Token: 0x060017E8 RID: 6120 RVA: 0x000695D0 File Offset: 0x000677D0
	public unsafe static bool IsInsideEditor
	{
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 194706, RefRangeEnd = 194715, XrefRangeStart = 194704, XrefRangeEnd = 194706, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_EditorTesting.NativeMethodInfoPtr_get_IsInsideEditor_Public_Static_get_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x060017E9 RID: 6121 RVA: 0x00069600 File Offset: 0x00067800
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 194716, RefRangeEnd = 194717, XrefRangeStart = 194715, XrefRangeEnd = 194716, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool HasFill(float fillRate)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref fillRate;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_EditorTesting.NativeMethodInfoPtr_HasFill_Public_Static_Boolean_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x060017EA RID: 6122 RVA: 0x00069640 File Offset: 0x00067840
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 194732, RefRangeEnd = 194734, XrefRangeStart = 194717, XrefRangeEnd = 194732, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void CheckForEventSystem()
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_EditorTesting.NativeMethodInfoPtr_CheckForEventSystem_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060017EB RID: 6123 RVA: 0x0000B862 File Offset: 0x00009A62
	public SA_EditorTesting(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x170006BB RID: 1723
	// (get) Token: 0x060017EC RID: 6124 RVA: 0x00069668 File Offset: 0x00067868
	// (set) Token: 0x060017ED RID: 6125 RVA: 0x0000B86B File Offset: 0x00009A6B
	public unsafe static int DEFAULT_SORT_ORDER
	{
		get
		{
			int num;
			IL2CPP.il2cpp_field_static_get_value(SA_EditorTesting.NativeFieldInfoPtr_DEFAULT_SORT_ORDER, (void*)(&num));
			return num;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(SA_EditorTesting.NativeFieldInfoPtr_DEFAULT_SORT_ORDER, (void*)(&value));
		}
	}

	// Token: 0x04001214 RID: 4628
	private static readonly IntPtr NativeFieldInfoPtr_DEFAULT_SORT_ORDER;

	// Token: 0x04001215 RID: 4629
	private static readonly IntPtr NativeMethodInfoPtr_get_IsInsideEditor_Public_Static_get_Boolean_0;

	// Token: 0x04001216 RID: 4630
	private static readonly IntPtr NativeMethodInfoPtr_HasFill_Public_Static_Boolean_Single_0;

	// Token: 0x04001217 RID: 4631
	private static readonly IntPtr NativeMethodInfoPtr_CheckForEventSystem_Public_Static_Void_0;
}
