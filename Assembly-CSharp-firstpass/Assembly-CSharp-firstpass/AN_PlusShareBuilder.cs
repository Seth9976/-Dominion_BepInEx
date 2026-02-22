using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using SA.Common.Models;
using UnityEngine;

// Token: 0x0200002A RID: 42
public class AN_PlusShareBuilder : global::Il2CppSystem.Object
{
	// Token: 0x0600043E RID: 1086 RVA: 0x00024ED4 File Offset: 0x000230D4
	// Note: this type is marked as 'beforefieldinit'.
	static AN_PlusShareBuilder()
	{
		Il2CppClassPointerStore<AN_PlusShareBuilder>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "AN_PlusShareBuilder");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AN_PlusShareBuilder>.NativeClassPtr);
		AN_PlusShareBuilder.NativeFieldInfoPtr_OnPlusShareResult = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AN_PlusShareBuilder>.NativeClassPtr, "OnPlusShareResult");
		AN_PlusShareBuilder.NativeFieldInfoPtr_LISTENER_OBJECT_NAME = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AN_PlusShareBuilder>.NativeClassPtr, "LISTENER_OBJECT_NAME");
		AN_PlusShareBuilder.NativeFieldInfoPtr_listenerObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AN_PlusShareBuilder>.NativeClassPtr, "listenerObject");
		AN_PlusShareBuilder.NativeFieldInfoPtr_message = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AN_PlusShareBuilder>.NativeClassPtr, "message");
		AN_PlusShareBuilder.NativeFieldInfoPtr_images = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AN_PlusShareBuilder>.NativeClassPtr, "images");
		AN_PlusShareBuilder.NativeMethodInfoPtr_add_OnPlusShareResult_Public_add_Void_Action_1_Result_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AN_PlusShareBuilder>.NativeClassPtr, 100663778);
		AN_PlusShareBuilder.NativeMethodInfoPtr_remove_OnPlusShareResult_Public_rem_Void_Action_1_Result_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AN_PlusShareBuilder>.NativeClassPtr, 100663779);
		AN_PlusShareBuilder.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AN_PlusShareBuilder>.NativeClassPtr, 100663780);
		AN_PlusShareBuilder.NativeMethodInfoPtr_AddImage_Public_Void_Texture2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AN_PlusShareBuilder>.NativeClassPtr, 100663781);
		AN_PlusShareBuilder.NativeMethodInfoPtr_Share_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AN_PlusShareBuilder>.NativeClassPtr, 100663782);
		AN_PlusShareBuilder.NativeMethodInfoPtr_PlusShareCallback_Private_Void_Result_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AN_PlusShareBuilder>.NativeClassPtr, 100663783);
	}

	// Token: 0x0600043F RID: 1087 RVA: 0x00024FE0 File Offset: 0x000231E0
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 163409, XrefRangeEnd = 163413, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void add_OnPlusShareResult(Action<Result> value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AN_PlusShareBuilder.NativeMethodInfoPtr_add_OnPlusShareResult_Public_add_Void_Action_1_Result_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000440 RID: 1088 RVA: 0x00025024 File Offset: 0x00023224
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 163413, XrefRangeEnd = 163417, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void remove_OnPlusShareResult(Action<Result> value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AN_PlusShareBuilder.NativeMethodInfoPtr_remove_OnPlusShareResult_Public_rem_Void_Action_1_Result_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000441 RID: 1089 RVA: 0x00025068 File Offset: 0x00023268
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 163417, XrefRangeEnd = 163424, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe AN_PlusShareBuilder(string text)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AN_PlusShareBuilder>.NativeClassPtr))
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AN_PlusShareBuilder.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000442 RID: 1090 RVA: 0x000250B4 File Offset: 0x000232B4
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 163424, XrefRangeEnd = 163428, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AddImage(Texture2D image)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(image);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AN_PlusShareBuilder.NativeMethodInfoPtr_AddImage_Public_Void_Texture2D_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000443 RID: 1091 RVA: 0x000250F8 File Offset: 0x000232F8
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 163428, XrefRangeEnd = 163484, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Share()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AN_PlusShareBuilder.NativeMethodInfoPtr_Share_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000444 RID: 1092 RVA: 0x0002512C File Offset: 0x0002332C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 163484, XrefRangeEnd = 163500, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void PlusShareCallback(Result result)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AN_PlusShareBuilder.NativeMethodInfoPtr_PlusShareCallback_Private_Void_Result_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000445 RID: 1093 RVA: 0x00003D86 File Offset: 0x00001F86
	public AN_PlusShareBuilder(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x17000171 RID: 369
	// (get) Token: 0x06000446 RID: 1094 RVA: 0x00025170 File Offset: 0x00023370
	// (set) Token: 0x06000447 RID: 1095 RVA: 0x00003D8F File Offset: 0x00001F8F
	public unsafe Action<Result> OnPlusShareResult
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AN_PlusShareBuilder.NativeFieldInfoPtr_OnPlusShareResult);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<Result>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AN_PlusShareBuilder.NativeFieldInfoPtr_OnPlusShareResult), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000172 RID: 370
	// (get) Token: 0x06000448 RID: 1096 RVA: 0x000251A0 File Offset: 0x000233A0
	// (set) Token: 0x06000449 RID: 1097 RVA: 0x00003DAE File Offset: 0x00001FAE
	public unsafe static string LISTENER_OBJECT_NAME
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(AN_PlusShareBuilder.NativeFieldInfoPtr_LISTENER_OBJECT_NAME, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(AN_PlusShareBuilder.NativeFieldInfoPtr_LISTENER_OBJECT_NAME, IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x17000173 RID: 371
	// (get) Token: 0x0600044A RID: 1098 RVA: 0x000251C0 File Offset: 0x000233C0
	// (set) Token: 0x0600044B RID: 1099 RVA: 0x00003DC0 File Offset: 0x00001FC0
	public unsafe GameObject listenerObject
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AN_PlusShareBuilder.NativeFieldInfoPtr_listenerObject);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AN_PlusShareBuilder.NativeFieldInfoPtr_listenerObject), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000174 RID: 372
	// (get) Token: 0x0600044C RID: 1100 RVA: 0x000251F0 File Offset: 0x000233F0
	// (set) Token: 0x0600044D RID: 1101 RVA: 0x00003DDF File Offset: 0x00001FDF
	public unsafe string message
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AN_PlusShareBuilder.NativeFieldInfoPtr_message);
			return IL2CPP.Il2CppStringToManaged(*intPtr);
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AN_PlusShareBuilder.NativeFieldInfoPtr_message), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x17000175 RID: 373
	// (get) Token: 0x0600044E RID: 1102 RVA: 0x00025218 File Offset: 0x00023418
	// (set) Token: 0x0600044F RID: 1103 RVA: 0x00003DFE File Offset: 0x00001FFE
	public unsafe List<Texture2D> images
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AN_PlusShareBuilder.NativeFieldInfoPtr_images);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Texture2D>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AN_PlusShareBuilder.NativeFieldInfoPtr_images), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x04000330 RID: 816
	private static readonly IntPtr NativeFieldInfoPtr_OnPlusShareResult;

	// Token: 0x04000331 RID: 817
	private static readonly IntPtr NativeFieldInfoPtr_LISTENER_OBJECT_NAME;

	// Token: 0x04000332 RID: 818
	private static readonly IntPtr NativeFieldInfoPtr_listenerObject;

	// Token: 0x04000333 RID: 819
	private static readonly IntPtr NativeFieldInfoPtr_message;

	// Token: 0x04000334 RID: 820
	private static readonly IntPtr NativeFieldInfoPtr_images;

	// Token: 0x04000335 RID: 821
	private static readonly IntPtr NativeMethodInfoPtr_add_OnPlusShareResult_Public_add_Void_Action_1_Result_0;

	// Token: 0x04000336 RID: 822
	private static readonly IntPtr NativeMethodInfoPtr_remove_OnPlusShareResult_Public_rem_Void_Action_1_Result_0;

	// Token: 0x04000337 RID: 823
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

	// Token: 0x04000338 RID: 824
	private static readonly IntPtr NativeMethodInfoPtr_AddImage_Public_Void_Texture2D_0;

	// Token: 0x04000339 RID: 825
	private static readonly IntPtr NativeMethodInfoPtr_Share_Public_Void_0;

	// Token: 0x0400033A RID: 826
	private static readonly IntPtr NativeMethodInfoPtr_PlusShareCallback_Private_Void_Result_0;
}
