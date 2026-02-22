using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem.Runtime.Serialization;

namespace Il2CppSystem.Text
{
	// Token: 0x02000166 RID: 358
	[Serializable]
	public sealed class EncoderFallbackException : ArgumentException
	{
		// Token: 0x06001829 RID: 6185 RVA: 0x0008E9B8 File Offset: 0x0008CBB8
		// Note: this type is marked as 'beforefieldinit'.
		static EncoderFallbackException()
		{
			Il2CppClassPointerStore<EncoderFallbackException>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Text", "EncoderFallbackException");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EncoderFallbackException>.NativeClassPtr);
			EncoderFallbackException.NativeFieldInfoPtr_charUnknown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EncoderFallbackException>.NativeClassPtr, "charUnknown");
			EncoderFallbackException.NativeFieldInfoPtr_charUnknownHigh = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EncoderFallbackException>.NativeClassPtr, "charUnknownHigh");
			EncoderFallbackException.NativeFieldInfoPtr_charUnknownLow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EncoderFallbackException>.NativeClassPtr, "charUnknownLow");
			EncoderFallbackException.NativeFieldInfoPtr_index = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EncoderFallbackException>.NativeClassPtr, "index");
			EncoderFallbackException.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EncoderFallbackException>.NativeClassPtr, 100667314);
			EncoderFallbackException.NativeMethodInfoPtr__ctor_Internal_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EncoderFallbackException>.NativeClassPtr, 100667315);
			EncoderFallbackException.NativeMethodInfoPtr__ctor_Internal_Void_String_Char_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EncoderFallbackException>.NativeClassPtr, 100667316);
			EncoderFallbackException.NativeMethodInfoPtr__ctor_Internal_Void_String_Char_Char_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EncoderFallbackException>.NativeClassPtr, 100667317);
		}

		// Token: 0x0600182A RID: 6186 RVA: 0x0008EA88 File Offset: 0x0008CC88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 310396, XrefRangeEnd = 310401, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EncoderFallbackException()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EncoderFallbackException>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EncoderFallbackException.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600182B RID: 6187 RVA: 0x0008EAC4 File Offset: 0x0008CCC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EncoderFallbackException(SerializationInfo info, StreamingContext context)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EncoderFallbackException>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EncoderFallbackException.NativeMethodInfoPtr__ctor_Internal_Void_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600182C RID: 6188 RVA: 0x0008EB28 File Offset: 0x0008CD28
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 310402, RefRangeEnd = 310403, XrefRangeStart = 310401, XrefRangeEnd = 310402, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EncoderFallbackException(string message, char charUnknown, int index)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EncoderFallbackException>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref charUnknown;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EncoderFallbackException.NativeMethodInfoPtr__ctor_Internal_Void_String_Char_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600182D RID: 6189 RVA: 0x0008EB90 File Offset: 0x0008CD90
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 310411, RefRangeEnd = 310412, XrefRangeStart = 310403, XrefRangeEnd = 310411, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EncoderFallbackException(string message, char charUnknownHigh, char charUnknownLow, int index)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EncoderFallbackException>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref charUnknownHigh;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref charUnknownLow;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EncoderFallbackException.NativeMethodInfoPtr__ctor_Internal_Void_String_Char_Char_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600182E RID: 6190 RVA: 0x000087A0 File Offset: 0x000069A0
		public EncoderFallbackException(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170004B2 RID: 1202
		// (get) Token: 0x0600182F RID: 6191 RVA: 0x0008EC08 File Offset: 0x0008CE08
		// (set) Token: 0x06001830 RID: 6192 RVA: 0x000087A9 File Offset: 0x000069A9
		public unsafe char charUnknown
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EncoderFallbackException.NativeFieldInfoPtr_charUnknown);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EncoderFallbackException.NativeFieldInfoPtr_charUnknown)) = value;
			}
		}

		// Token: 0x170004B3 RID: 1203
		// (get) Token: 0x06001831 RID: 6193 RVA: 0x0008EC30 File Offset: 0x0008CE30
		// (set) Token: 0x06001832 RID: 6194 RVA: 0x000087C4 File Offset: 0x000069C4
		public unsafe char charUnknownHigh
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EncoderFallbackException.NativeFieldInfoPtr_charUnknownHigh);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EncoderFallbackException.NativeFieldInfoPtr_charUnknownHigh)) = value;
			}
		}

		// Token: 0x170004B4 RID: 1204
		// (get) Token: 0x06001833 RID: 6195 RVA: 0x0008EC58 File Offset: 0x0008CE58
		// (set) Token: 0x06001834 RID: 6196 RVA: 0x000087DF File Offset: 0x000069DF
		public unsafe char charUnknownLow
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EncoderFallbackException.NativeFieldInfoPtr_charUnknownLow);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EncoderFallbackException.NativeFieldInfoPtr_charUnknownLow)) = value;
			}
		}

		// Token: 0x170004B5 RID: 1205
		// (get) Token: 0x06001835 RID: 6197 RVA: 0x0008EC80 File Offset: 0x0008CE80
		// (set) Token: 0x06001836 RID: 6198 RVA: 0x000087FA File Offset: 0x000069FA
		public unsafe int index
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EncoderFallbackException.NativeFieldInfoPtr_index);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EncoderFallbackException.NativeFieldInfoPtr_index)) = value;
			}
		}

		// Token: 0x0400163C RID: 5692
		private static readonly IntPtr NativeFieldInfoPtr_charUnknown;

		// Token: 0x0400163D RID: 5693
		private static readonly IntPtr NativeFieldInfoPtr_charUnknownHigh;

		// Token: 0x0400163E RID: 5694
		private static readonly IntPtr NativeFieldInfoPtr_charUnknownLow;

		// Token: 0x0400163F RID: 5695
		private static readonly IntPtr NativeFieldInfoPtr_index;

		// Token: 0x04001640 RID: 5696
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04001641 RID: 5697
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_SerializationInfo_StreamingContext_0;

		// Token: 0x04001642 RID: 5698
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_String_Char_Int32_0;

		// Token: 0x04001643 RID: 5699
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_String_Char_Char_Int32_0;
	}
}
