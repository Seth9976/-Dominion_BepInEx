using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace UnityEngine.Bindings
{
	// Token: 0x0200000F RID: 15
	public class NativePropertyAttribute : NativeMethodAttribute
	{
		// Token: 0x06000067 RID: 103 RVA: 0x000036B0 File Offset: 0x000018B0
		// Note: this type is marked as 'beforefieldinit'.
		static NativePropertyAttribute()
		{
			Il2CppClassPointerStore<NativePropertyAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.SharedInternalsModule.dll", "UnityEngine.Bindings", "NativePropertyAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NativePropertyAttribute>.NativeClassPtr);
			NativePropertyAttribute.NativeFieldInfoPtr__TargetType_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NativePropertyAttribute>.NativeClassPtr, "<TargetType>k__BackingField");
			NativePropertyAttribute.NativeMethodInfoPtr_set_TargetType_Public_set_Void_TargetType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativePropertyAttribute>.NativeClassPtr, 100663326);
			NativePropertyAttribute.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativePropertyAttribute>.NativeClassPtr, 100663327);
			NativePropertyAttribute.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativePropertyAttribute>.NativeClassPtr, 100663328);
			NativePropertyAttribute.NativeMethodInfoPtr__ctor_Public_Void_String_Boolean_TargetType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativePropertyAttribute>.NativeClassPtr, 100663329);
		}

		// Token: 0x17000020 RID: 32
		// (get) Token: 0x0600006F RID: 111 RVA: 0x0000242D File Offset: 0x0000062D
		// (set) Token: 0x06000068 RID: 104 RVA: 0x00003744 File Offset: 0x00001944
		public unsafe TargetType TargetType
		{
			get
			{
				return this._TargetType_k__BackingField;
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativePropertyAttribute.NativeMethodInfoPtr_set_TargetType_Public_set_Void_TargetType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000069 RID: 105 RVA: 0x00003784 File Offset: 0x00001984
		[CallerCount(114)]
		[CachedScanResults(RefRangeStart = 12105, RefRangeEnd = 12219, XrefRangeStart = 12105, XrefRangeEnd = 12219, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NativePropertyAttribute()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NativePropertyAttribute>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativePropertyAttribute.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600006A RID: 106 RVA: 0x000037C0 File Offset: 0x000019C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 58930, XrefRangeEnd = 58931, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NativePropertyAttribute(string name)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NativePropertyAttribute>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativePropertyAttribute.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600006B RID: 107 RVA: 0x0000380C File Offset: 0x00001A0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 58931, XrefRangeEnd = 58932, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NativePropertyAttribute(string name, bool isFree, TargetType targetType)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NativePropertyAttribute>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isFree;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref targetType;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativePropertyAttribute.NativeMethodInfoPtr__ctor_Public_Void_String_Boolean_TargetType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600006C RID: 108 RVA: 0x00002409 File Offset: 0x00000609
		public NativePropertyAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700001F RID: 31
		// (get) Token: 0x0600006D RID: 109 RVA: 0x00003874 File Offset: 0x00001A74
		// (set) Token: 0x0600006E RID: 110 RVA: 0x00002412 File Offset: 0x00000612
		public unsafe TargetType _TargetType_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NativePropertyAttribute.NativeFieldInfoPtr__TargetType_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NativePropertyAttribute.NativeFieldInfoPtr__TargetType_k__BackingField)) = value;
			}
		}

		// Token: 0x0400002F RID: 47
		private static readonly IntPtr NativeFieldInfoPtr__TargetType_k__BackingField;

		// Token: 0x04000030 RID: 48
		private static readonly IntPtr NativeMethodInfoPtr_set_TargetType_Public_set_Void_TargetType_0;

		// Token: 0x04000031 RID: 49
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000032 RID: 50
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		// Token: 0x04000033 RID: 51
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Boolean_TargetType_0;
	}
}
