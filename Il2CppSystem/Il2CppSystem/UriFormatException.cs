using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem.Runtime.Serialization;

namespace Il2CppSystem
{
	// Token: 0x02000030 RID: 48
	[Serializable]
	public class UriFormatException : FormatException
	{
		// Token: 0x06000330 RID: 816 RVA: 0x0001D498 File Offset: 0x0001B698
		// Note: this type is marked as 'beforefieldinit'.
		static UriFormatException()
		{
			Il2CppClassPointerStore<UriFormatException>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System", "UriFormatException");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UriFormatException>.NativeClassPtr);
			UriFormatException.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UriFormatException>.NativeClassPtr, 100663821);
			UriFormatException.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UriFormatException>.NativeClassPtr, 100663822);
			UriFormatException.NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UriFormatException>.NativeClassPtr, 100663823);
			UriFormatException.NativeMethodInfoPtr_System_Runtime_Serialization_ISerializable_GetObjectData_Private_Virtual_Final_New_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UriFormatException>.NativeClassPtr, 100663824);
		}

		// Token: 0x06000331 RID: 817 RVA: 0x0001D518 File Offset: 0x0001B718
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 36364, XrefRangeEnd = 36365, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UriFormatException()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UriFormatException>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UriFormatException.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000332 RID: 818 RVA: 0x0001D554 File Offset: 0x0001B754
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 36366, RefRangeEnd = 36367, XrefRangeStart = 36365, XrefRangeEnd = 36366, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UriFormatException(string textString)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UriFormatException>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(textString);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UriFormatException.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000333 RID: 819 RVA: 0x0001D5A0 File Offset: 0x0001B7A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 36367, XrefRangeEnd = 36368, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UriFormatException(SerializationInfo serializationInfo, StreamingContext streamingContext)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UriFormatException>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(serializationInfo);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(streamingContext));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UriFormatException.NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000334 RID: 820 RVA: 0x0001D604 File Offset: 0x0001B804
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 36368, XrefRangeEnd = 36369, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void System_Runtime_Serialization_ISerializable_GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(serializationInfo);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(streamingContext));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UriFormatException.NativeMethodInfoPtr_System_Runtime_Serialization_ISerializable_GetObjectData_Private_Virtual_Final_New_Void_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000335 RID: 821 RVA: 0x000031E5 File Offset: 0x000013E5
		public UriFormatException(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400024D RID: 589
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400024E RID: 590
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		// Token: 0x0400024F RID: 591
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0;

		// Token: 0x04000250 RID: 592
		private static readonly IntPtr NativeMethodInfoPtr_System_Runtime_Serialization_ISerializable_GetObjectData_Private_Virtual_Final_New_Void_SerializationInfo_StreamingContext_0;
	}
}
