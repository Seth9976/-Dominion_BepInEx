using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

// Token: 0x020000E6 RID: 230
public static class ParsePushesStub : Object
{
	// Token: 0x06001091 RID: 4241 RVA: 0x000514AC File Offset: 0x0004F6AC
	// Note: this type is marked as 'beforefieldinit'.
	static ParsePushesStub()
	{
		Il2CppClassPointerStore<ParsePushesStub>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "ParsePushesStub");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ParsePushesStub>.NativeClassPtr);
		ParsePushesStub.NativeFieldInfoPtr_OnPushReceived = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParsePushesStub>.NativeClassPtr, "OnPushReceived");
		ParsePushesStub.NativeMethodInfoPtr_add_OnPushReceived_Public_Static_add_Void_Action_2_String_Dictionary_2_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParsePushesStub>.NativeClassPtr, 100665346);
		ParsePushesStub.NativeMethodInfoPtr_remove_OnPushReceived_Public_Static_rem_Void_Action_2_String_Dictionary_2_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParsePushesStub>.NativeClassPtr, 100665347);
		ParsePushesStub.NativeMethodInfoPtr_InitParse_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParsePushesStub>.NativeClassPtr, 100665348);
	}

	// Token: 0x06001092 RID: 4242 RVA: 0x0005152C File Offset: 0x0004F72C
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 181324, RefRangeEnd = 181326, XrefRangeStart = 181313, XrefRangeEnd = 181324, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void add_OnPushReceived(Action<string, Dictionary<string, Object>> value)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParsePushesStub.NativeMethodInfoPtr_add_OnPushReceived_Public_Static_add_Void_Action_2_String_Dictionary_2_String_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06001093 RID: 4243 RVA: 0x00051564 File Offset: 0x0004F764
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 181326, XrefRangeEnd = 181337, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void remove_OnPushReceived(Action<string, Dictionary<string, Object>> value)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParsePushesStub.NativeMethodInfoPtr_remove_OnPushReceived_Public_Static_rem_Void_Action_2_String_Dictionary_2_String_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06001094 RID: 4244 RVA: 0x0005159C File Offset: 0x0004F79C
	[CallerCount(3728)]
	[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void InitParse()
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParsePushesStub.NativeMethodInfoPtr_InitParse_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06001095 RID: 4245 RVA: 0x00008422 File Offset: 0x00006622
	public ParsePushesStub(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x170004DC RID: 1244
	// (get) Token: 0x06001096 RID: 4246 RVA: 0x000515C4 File Offset: 0x0004F7C4
	// (set) Token: 0x06001097 RID: 4247 RVA: 0x0000842B File Offset: 0x0000662B
	public unsafe static Action<string, Dictionary<string, Object>> OnPushReceived
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(ParsePushesStub.NativeFieldInfoPtr_OnPushReceived, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<string, Dictionary<string, Object>>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(ParsePushesStub.NativeFieldInfoPtr_OnPushReceived, IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x04000D04 RID: 3332
	private static readonly IntPtr NativeFieldInfoPtr_OnPushReceived;

	// Token: 0x04000D05 RID: 3333
	private static readonly IntPtr NativeMethodInfoPtr_add_OnPushReceived_Public_Static_add_Void_Action_2_String_Dictionary_2_String_Object_0;

	// Token: 0x04000D06 RID: 3334
	private static readonly IntPtr NativeMethodInfoPtr_remove_OnPushReceived_Public_Static_rem_Void_Action_2_String_Dictionary_2_String_Object_0;

	// Token: 0x04000D07 RID: 3335
	private static readonly IntPtr NativeMethodInfoPtr_InitParse_Public_Static_Void_0;

	// Token: 0x02000399 RID: 921
	[ObfuscatedName("ParsePushesStub+<>c")]
	[Serializable]
	public sealed class __c : Object
	{
		// Token: 0x06003696 RID: 13974 RVA: 0x000DFCB4 File Offset: 0x000DDEB4
		// Note: this type is marked as 'beforefieldinit'.
		static __c()
		{
			Il2CppClassPointerStore<ParsePushesStub.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ParsePushesStub>.NativeClassPtr, "<>c");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ParsePushesStub.__c>.NativeClassPtr);
			ParsePushesStub.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParsePushesStub.__c>.NativeClassPtr, "<>9");
			ParsePushesStub.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParsePushesStub.__c>.NativeClassPtr, 100670238);
			ParsePushesStub.__c.NativeMethodInfoPtr___cctor_b__4_0_Internal_Void_String_Dictionary_2_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParsePushesStub.__c>.NativeClassPtr, 100670239);
		}

		// Token: 0x06003697 RID: 13975 RVA: 0x000DFD1C File Offset: 0x000DDF1C
		[CallerCount(817)]
		[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe __c()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ParsePushesStub.__c>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParsePushesStub.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003698 RID: 13976 RVA: 0x000DFD58 File Offset: 0x000DDF58
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void __cctor_b__4_0(string <p0>, Dictionary<string, Object> <p1>)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(<p0>);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(<p1>);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParsePushesStub.__c.NativeMethodInfoPtr___cctor_b__4_0_Internal_Void_String_Dictionary_2_String_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003699 RID: 13977 RVA: 0x000152A8 File Offset: 0x000134A8
		public __c(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000D0B RID: 3339
		// (get) Token: 0x0600369A RID: 13978 RVA: 0x000DFDAC File Offset: 0x000DDFAC
		// (set) Token: 0x0600369B RID: 13979 RVA: 0x000152B1 File Offset: 0x000134B1
		public unsafe static ParsePushesStub.__c __9
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ParsePushesStub.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ParsePushesStub.__c>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ParsePushesStub.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040031E0 RID: 12768
		private static readonly IntPtr NativeFieldInfoPtr___9;

		// Token: 0x040031E1 RID: 12769
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040031E2 RID: 12770
		private static readonly IntPtr NativeMethodInfoPtr___cctor_b__4_0_Internal_Void_String_Dictionary_2_String_Object_0;
	}
}
