using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;

// Token: 0x020000C6 RID: 198
public class AN_PlusButtonProxy : Object
{
	// Token: 0x06000E55 RID: 3669 RVA: 0x00049EE4 File Offset: 0x000480E4
	// Note: this type is marked as 'beforefieldinit'.
	static AN_PlusButtonProxy()
	{
		Il2CppClassPointerStore<AN_PlusButtonProxy>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "AN_PlusButtonProxy");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AN_PlusButtonProxy>.NativeClassPtr);
		AN_PlusButtonProxy.NativeFieldInfoPtr_CLASS_NAME = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AN_PlusButtonProxy>.NativeClassPtr, "CLASS_NAME");
		AN_PlusButtonProxy.NativeMethodInfoPtr_CallActivityFunction_Private_Static_Void_String_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AN_PlusButtonProxy>.NativeClassPtr, 100665099);
		AN_PlusButtonProxy.NativeMethodInfoPtr_createPlusButton_Public_Static_Void_Int32_String_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AN_PlusButtonProxy>.NativeClassPtr, 100665100);
		AN_PlusButtonProxy.NativeMethodInfoPtr_setGravity_Public_Static_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AN_PlusButtonProxy>.NativeClassPtr, 100665101);
		AN_PlusButtonProxy.NativeMethodInfoPtr_setPosition_Public_Static_Void_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AN_PlusButtonProxy>.NativeClassPtr, 100665102);
		AN_PlusButtonProxy.NativeMethodInfoPtr_show_Public_Static_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AN_PlusButtonProxy>.NativeClassPtr, 100665103);
		AN_PlusButtonProxy.NativeMethodInfoPtr_hide_Public_Static_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AN_PlusButtonProxy>.NativeClassPtr, 100665104);
		AN_PlusButtonProxy.NativeMethodInfoPtr_refresh_Public_Static_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AN_PlusButtonProxy>.NativeClassPtr, 100665105);
		AN_PlusButtonProxy.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AN_PlusButtonProxy>.NativeClassPtr, 100665106);
	}

	// Token: 0x06000E56 RID: 3670 RVA: 0x00049FC8 File Offset: 0x000481C8
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 178509, XrefRangeEnd = 178510, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void CallActivityFunction(string methodName, [Optional] Il2CppReferenceArray<Object> args)
	{
		if (args == null)
		{
			args = new Il2CppReferenceArray<Object>(0L);
		}
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(methodName);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AN_PlusButtonProxy.NativeMethodInfoPtr_CallActivityFunction_Private_Static_Void_String_Il2CppReferenceArray_1_Object_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000E57 RID: 3671 RVA: 0x0004A020 File Offset: 0x00048220
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 178526, RefRangeEnd = 178527, XrefRangeStart = 178510, XrefRangeEnd = 178526, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void createPlusButton(int id, string url, int size, int annotation)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref id;
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(url);
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref size;
		ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref annotation;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AN_PlusButtonProxy.NativeMethodInfoPtr_createPlusButton_Public_Static_Void_Int32_String_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000E58 RID: 3672 RVA: 0x0004A080 File Offset: 0x00048280
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 178527, XrefRangeEnd = 178539, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void setGravity(int gravity, int id)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref gravity;
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref id;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AN_PlusButtonProxy.NativeMethodInfoPtr_setGravity_Public_Static_Void_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000E59 RID: 3673 RVA: 0x0004A0C0 File Offset: 0x000482C0
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 178554, RefRangeEnd = 178555, XrefRangeStart = 178539, XrefRangeEnd = 178554, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void setPosition(int x, int y, int id)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref x;
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref id;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AN_PlusButtonProxy.NativeMethodInfoPtr_setPosition_Public_Static_Void_Int32_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000E5A RID: 3674 RVA: 0x0004A110 File Offset: 0x00048310
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 178555, XrefRangeEnd = 178564, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void show(int id)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref id;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AN_PlusButtonProxy.NativeMethodInfoPtr_show_Public_Static_Void_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000E5B RID: 3675 RVA: 0x0004A144 File Offset: 0x00048344
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 178564, XrefRangeEnd = 178573, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void hide(int id)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref id;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AN_PlusButtonProxy.NativeMethodInfoPtr_hide_Public_Static_Void_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000E5C RID: 3676 RVA: 0x0004A178 File Offset: 0x00048378
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 178573, XrefRangeEnd = 178582, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void refresh(int id)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref id;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AN_PlusButtonProxy.NativeMethodInfoPtr_refresh_Public_Static_Void_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000E5D RID: 3677 RVA: 0x0004A1AC File Offset: 0x000483AC
	[CallerCount(817)]
	[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe AN_PlusButtonProxy()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AN_PlusButtonProxy>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AN_PlusButtonProxy.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000E5E RID: 3678 RVA: 0x00007724 File Offset: 0x00005924
	public static void CallActivityFunction(string methodName, params Object[] args)
	{
		AN_PlusButtonProxy.CallActivityFunction(methodName, new Il2CppReferenceArray<Object>(args));
	}

	// Token: 0x06000E5F RID: 3679 RVA: 0x00007732 File Offset: 0x00005932
	public AN_PlusButtonProxy(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x1700043C RID: 1084
	// (get) Token: 0x06000E60 RID: 3680 RVA: 0x0004A1E8 File Offset: 0x000483E8
	// (set) Token: 0x06000E61 RID: 3681 RVA: 0x0000773B File Offset: 0x0000593B
	public unsafe static string CLASS_NAME
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(AN_PlusButtonProxy.NativeFieldInfoPtr_CLASS_NAME, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(AN_PlusButtonProxy.NativeFieldInfoPtr_CLASS_NAME, IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x04000B25 RID: 2853
	private static readonly IntPtr NativeFieldInfoPtr_CLASS_NAME;

	// Token: 0x04000B26 RID: 2854
	private static readonly IntPtr NativeMethodInfoPtr_CallActivityFunction_Private_Static_Void_String_Il2CppReferenceArray_1_Object_0;

	// Token: 0x04000B27 RID: 2855
	private static readonly IntPtr NativeMethodInfoPtr_createPlusButton_Public_Static_Void_Int32_String_Int32_Int32_0;

	// Token: 0x04000B28 RID: 2856
	private static readonly IntPtr NativeMethodInfoPtr_setGravity_Public_Static_Void_Int32_Int32_0;

	// Token: 0x04000B29 RID: 2857
	private static readonly IntPtr NativeMethodInfoPtr_setPosition_Public_Static_Void_Int32_Int32_Int32_0;

	// Token: 0x04000B2A RID: 2858
	private static readonly IntPtr NativeMethodInfoPtr_show_Public_Static_Void_Int32_0;

	// Token: 0x04000B2B RID: 2859
	private static readonly IntPtr NativeMethodInfoPtr_hide_Public_Static_Void_Int32_0;

	// Token: 0x04000B2C RID: 2860
	private static readonly IntPtr NativeMethodInfoPtr_refresh_Public_Static_Void_Int32_0;

	// Token: 0x04000B2D RID: 2861
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
}
