using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem
{
	// Token: 0x020000D5 RID: 213
	[Serializable]
	public sealed class ObsoleteAttribute : Attribute
	{
		// Token: 0x06000E31 RID: 3633 RVA: 0x00062D20 File Offset: 0x00060F20
		// Note: this type is marked as 'beforefieldinit'.
		static ObsoleteAttribute()
		{
			Il2CppClassPointerStore<ObsoleteAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "ObsoleteAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ObsoleteAttribute>.NativeClassPtr);
			ObsoleteAttribute.NativeFieldInfoPtr__message = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObsoleteAttribute>.NativeClassPtr, "_message");
			ObsoleteAttribute.NativeFieldInfoPtr__error = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObsoleteAttribute>.NativeClassPtr, "_error");
			ObsoleteAttribute.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObsoleteAttribute>.NativeClassPtr, 100665698);
			ObsoleteAttribute.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObsoleteAttribute>.NativeClassPtr, 100665699);
			ObsoleteAttribute.NativeMethodInfoPtr__ctor_Public_Void_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObsoleteAttribute>.NativeClassPtr, 100665700);
			ObsoleteAttribute.NativeMethodInfoPtr_get_Message_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObsoleteAttribute>.NativeClassPtr, 100665701);
		}

		// Token: 0x06000E32 RID: 3634 RVA: 0x00062DC8 File Offset: 0x00060FC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 290281, XrefRangeEnd = 290282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ObsoleteAttribute()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ObsoleteAttribute>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObsoleteAttribute.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E33 RID: 3635 RVA: 0x00062E04 File Offset: 0x00061004
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 290282, XrefRangeEnd = 290283, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ObsoleteAttribute(string message)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ObsoleteAttribute>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObsoleteAttribute.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000E34 RID: 3636 RVA: 0x00062E50 File Offset: 0x00061050
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 290283, XrefRangeEnd = 290284, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ObsoleteAttribute(string message, bool error)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ObsoleteAttribute>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref error;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObsoleteAttribute.NativeMethodInfoPtr__ctor_Public_Void_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000288 RID: 648
		// (get) Token: 0x06000E35 RID: 3637 RVA: 0x00062EAC File Offset: 0x000610AC
		public unsafe string Message
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 5319, RefRangeEnd = 5326, XrefRangeStart = 5319, XrefRangeEnd = 5326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObsoleteAttribute.NativeMethodInfoPtr_get_Message_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000E36 RID: 3638 RVA: 0x00005A21 File Offset: 0x00003C21
		public ObsoleteAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000286 RID: 646
		// (get) Token: 0x06000E37 RID: 3639 RVA: 0x00062EE4 File Offset: 0x000610E4
		// (set) Token: 0x06000E38 RID: 3640 RVA: 0x00005A2A File Offset: 0x00003C2A
		public unsafe string _message
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObsoleteAttribute.NativeFieldInfoPtr__message);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObsoleteAttribute.NativeFieldInfoPtr__message), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000287 RID: 647
		// (get) Token: 0x06000E39 RID: 3641 RVA: 0x00062F0C File Offset: 0x0006110C
		// (set) Token: 0x06000E3A RID: 3642 RVA: 0x00005A49 File Offset: 0x00003C49
		public unsafe bool _error
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObsoleteAttribute.NativeFieldInfoPtr__error);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObsoleteAttribute.NativeFieldInfoPtr__error)) = value;
			}
		}

		// Token: 0x04000C0F RID: 3087
		private static readonly IntPtr NativeFieldInfoPtr__message;

		// Token: 0x04000C10 RID: 3088
		private static readonly IntPtr NativeFieldInfoPtr__error;

		// Token: 0x04000C11 RID: 3089
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000C12 RID: 3090
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		// Token: 0x04000C13 RID: 3091
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Boolean_0;

		// Token: 0x04000C14 RID: 3092
		private static readonly IntPtr NativeMethodInfoPtr_get_Message_Public_get_String_0;
	}
}
