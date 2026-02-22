using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem
{
	// Token: 0x020000DA RID: 218
	public sealed class ParamsArray : ValueType
	{
		// Token: 0x06000E53 RID: 3667 RVA: 0x00063550 File Offset: 0x00061750
		// Note: this type is marked as 'beforefieldinit'.
		static ParamsArray()
		{
			Il2CppClassPointerStore<ParamsArray>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "ParamsArray");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ParamsArray>.NativeClassPtr);
			ParamsArray.NativeFieldInfoPtr_oneArgArray = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParamsArray>.NativeClassPtr, "oneArgArray");
			ParamsArray.NativeFieldInfoPtr_twoArgArray = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParamsArray>.NativeClassPtr, "twoArgArray");
			ParamsArray.NativeFieldInfoPtr_threeArgArray = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParamsArray>.NativeClassPtr, "threeArgArray");
			ParamsArray.NativeFieldInfoPtr_arg0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParamsArray>.NativeClassPtr, "arg0");
			ParamsArray.NativeFieldInfoPtr_arg1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParamsArray>.NativeClassPtr, "arg1");
			ParamsArray.NativeFieldInfoPtr_arg2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParamsArray>.NativeClassPtr, "arg2");
			ParamsArray.NativeFieldInfoPtr_args = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParamsArray>.NativeClassPtr, "args");
			ParamsArray.NativeMethodInfoPtr__ctor_Public_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParamsArray>.NativeClassPtr, 100665716);
			ParamsArray.NativeMethodInfoPtr__ctor_Public_Void_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParamsArray>.NativeClassPtr, 100665717);
			ParamsArray.NativeMethodInfoPtr__ctor_Public_Void_Object_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParamsArray>.NativeClassPtr, 100665718);
			ParamsArray.NativeMethodInfoPtr__ctor_Public_Void_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParamsArray>.NativeClassPtr, 100665719);
			ParamsArray.NativeMethodInfoPtr_get_Length_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParamsArray>.NativeClassPtr, 100665720);
			ParamsArray.NativeMethodInfoPtr_get_Item_Public_get_Object_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParamsArray>.NativeClassPtr, 100665721);
			ParamsArray.NativeMethodInfoPtr_GetAtSlow_Private_Object_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParamsArray>.NativeClassPtr, 100665722);
		}

		// Token: 0x06000E54 RID: 3668 RVA: 0x00063698 File Offset: 0x00061898
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 290323, RefRangeEnd = 290327, XrefRangeStart = 290319, XrefRangeEnd = 290323, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ParamsArray(Object arg0)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ParamsArray>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(arg0);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParamsArray.NativeMethodInfoPtr__ctor_Public_Void_Object_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000E55 RID: 3669 RVA: 0x000636E8 File Offset: 0x000618E8
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 290331, RefRangeEnd = 290335, XrefRangeStart = 290327, XrefRangeEnd = 290331, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ParamsArray(Object arg0, Object arg1)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ParamsArray>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(arg0);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(arg1);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParamsArray.NativeMethodInfoPtr__ctor_Public_Void_Object_Object_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E56 RID: 3670 RVA: 0x0006374C File Offset: 0x0006194C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 290339, RefRangeEnd = 290343, XrefRangeStart = 290335, XrefRangeEnd = 290339, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ParamsArray(Object arg0, Object arg1, Object arg2)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ParamsArray>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(arg0);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(arg1);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(arg2);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParamsArray.NativeMethodInfoPtr__ctor_Public_Void_Object_Object_Object_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E57 RID: 3671 RVA: 0x000637C0 File Offset: 0x000619C0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 290343, RefRangeEnd = 290346, XrefRangeStart = 290343, XrefRangeEnd = 290343, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ParamsArray(Il2CppReferenceArray<Object> args)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ParamsArray>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(args);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParamsArray.NativeMethodInfoPtr__ctor_Public_Void_Il2CppReferenceArray_1_Object_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000292 RID: 658
		// (get) Token: 0x06000E58 RID: 3672 RVA: 0x00063810 File Offset: 0x00061A10
		public unsafe int Length
		{
			[CallerCount(11)]
			[CachedScanResults(RefRangeStart = 290346, RefRangeEnd = 290357, XrefRangeStart = 290346, XrefRangeEnd = 290346, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParamsArray.NativeMethodInfoPtr_get_Length_Public_get_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000293 RID: 659
		public unsafe Object this[int index]
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 290357, RefRangeEnd = 290358, XrefRangeStart = 290357, XrefRangeEnd = 290357, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref index;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParamsArray.NativeMethodInfoPtr_get_Item_Public_get_Object_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}
		}

		// Token: 0x06000E5A RID: 3674 RVA: 0x000638A8 File Offset: 0x00061AA8
		[CallerCount(0)]
		public unsafe Object GetAtSlow(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParamsArray.NativeMethodInfoPtr_GetAtSlow_Private_Object_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x06000E5B RID: 3675 RVA: 0x00005AEF File Offset: 0x00003CEF
		public ParamsArray(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06000E5C RID: 3676 RVA: 0x00005AF8 File Offset: 0x00003CF8
		public ParamsArray()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ParamsArray>.NativeClassPtr))
		{
		}

		// Token: 0x1700028B RID: 651
		// (get) Token: 0x06000E5D RID: 3677 RVA: 0x000638FC File Offset: 0x00061AFC
		// (set) Token: 0x06000E5E RID: 3678 RVA: 0x00005B0A File Offset: 0x00003D0A
		public unsafe static Il2CppReferenceArray<Object> oneArgArray
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ParamsArray.NativeFieldInfoPtr_oneArgArray, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Object>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ParamsArray.NativeFieldInfoPtr_oneArgArray, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700028C RID: 652
		// (get) Token: 0x06000E5F RID: 3679 RVA: 0x00063924 File Offset: 0x00061B24
		// (set) Token: 0x06000E60 RID: 3680 RVA: 0x00005B1C File Offset: 0x00003D1C
		public unsafe static Il2CppReferenceArray<Object> twoArgArray
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ParamsArray.NativeFieldInfoPtr_twoArgArray, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Object>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ParamsArray.NativeFieldInfoPtr_twoArgArray, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700028D RID: 653
		// (get) Token: 0x06000E61 RID: 3681 RVA: 0x0006394C File Offset: 0x00061B4C
		// (set) Token: 0x06000E62 RID: 3682 RVA: 0x00005B2E File Offset: 0x00003D2E
		public unsafe static Il2CppReferenceArray<Object> threeArgArray
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ParamsArray.NativeFieldInfoPtr_threeArgArray, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Object>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ParamsArray.NativeFieldInfoPtr_threeArgArray, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700028E RID: 654
		// (get) Token: 0x06000E63 RID: 3683 RVA: 0x00063974 File Offset: 0x00061B74
		// (set) Token: 0x06000E64 RID: 3684 RVA: 0x00005B40 File Offset: 0x00003D40
		public unsafe Object arg0
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParamsArray.NativeFieldInfoPtr_arg0);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParamsArray.NativeFieldInfoPtr_arg0), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700028F RID: 655
		// (get) Token: 0x06000E65 RID: 3685 RVA: 0x000639A4 File Offset: 0x00061BA4
		// (set) Token: 0x06000E66 RID: 3686 RVA: 0x00005B5F File Offset: 0x00003D5F
		public unsafe Object arg1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParamsArray.NativeFieldInfoPtr_arg1);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParamsArray.NativeFieldInfoPtr_arg1), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000290 RID: 656
		// (get) Token: 0x06000E67 RID: 3687 RVA: 0x000639D4 File Offset: 0x00061BD4
		// (set) Token: 0x06000E68 RID: 3688 RVA: 0x00005B7E File Offset: 0x00003D7E
		public unsafe Object arg2
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParamsArray.NativeFieldInfoPtr_arg2);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParamsArray.NativeFieldInfoPtr_arg2), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000291 RID: 657
		// (get) Token: 0x06000E69 RID: 3689 RVA: 0x00063A04 File Offset: 0x00061C04
		// (set) Token: 0x06000E6A RID: 3690 RVA: 0x00005B9D File Offset: 0x00003D9D
		public unsafe Il2CppReferenceArray<Object> args
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParamsArray.NativeFieldInfoPtr_args);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Object>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParamsArray.NativeFieldInfoPtr_args), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000C24 RID: 3108
		private static readonly IntPtr NativeFieldInfoPtr_oneArgArray;

		// Token: 0x04000C25 RID: 3109
		private static readonly IntPtr NativeFieldInfoPtr_twoArgArray;

		// Token: 0x04000C26 RID: 3110
		private static readonly IntPtr NativeFieldInfoPtr_threeArgArray;

		// Token: 0x04000C27 RID: 3111
		private static readonly IntPtr NativeFieldInfoPtr_arg0;

		// Token: 0x04000C28 RID: 3112
		private static readonly IntPtr NativeFieldInfoPtr_arg1;

		// Token: 0x04000C29 RID: 3113
		private static readonly IntPtr NativeFieldInfoPtr_arg2;

		// Token: 0x04000C2A RID: 3114
		private static readonly IntPtr NativeFieldInfoPtr_args;

		// Token: 0x04000C2B RID: 3115
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_0;

		// Token: 0x04000C2C RID: 3116
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_Object_0;

		// Token: 0x04000C2D RID: 3117
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_Object_Object_0;

		// Token: 0x04000C2E RID: 3118
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Il2CppReferenceArray_1_Object_0;

		// Token: 0x04000C2F RID: 3119
		private static readonly IntPtr NativeMethodInfoPtr_get_Length_Public_get_Int32_0;

		// Token: 0x04000C30 RID: 3120
		private static readonly IntPtr NativeMethodInfoPtr_get_Item_Public_get_Object_Int32_0;

		// Token: 0x04000C31 RID: 3121
		private static readonly IntPtr NativeMethodInfoPtr_GetAtSlow_Private_Object_Int32_0;
	}
}
