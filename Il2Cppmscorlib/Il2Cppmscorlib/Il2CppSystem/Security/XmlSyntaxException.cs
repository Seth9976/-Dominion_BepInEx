using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem.Runtime.Serialization;

namespace Il2CppSystem.Security
{
	// Token: 0x020002C1 RID: 705
	[Serializable]
	public sealed class XmlSyntaxException : SystemException
	{
		// Token: 0x06002F31 RID: 12081 RVA: 0x000EDD5C File Offset: 0x000EBF5C
		// Note: this type is marked as 'beforefieldinit'.
		static XmlSyntaxException()
		{
			Il2CppClassPointerStore<XmlSyntaxException>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Security", "XmlSyntaxException");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XmlSyntaxException>.NativeClassPtr);
			XmlSyntaxException.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSyntaxException>.NativeClassPtr, 100670780);
			XmlSyntaxException.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSyntaxException>.NativeClassPtr, 100670781);
			XmlSyntaxException.NativeMethodInfoPtr__ctor_Public_Void_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSyntaxException>.NativeClassPtr, 100670782);
			XmlSyntaxException.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSyntaxException>.NativeClassPtr, 100670783);
			XmlSyntaxException.NativeMethodInfoPtr__ctor_Public_Void_String_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSyntaxException>.NativeClassPtr, 100670784);
			XmlSyntaxException.NativeMethodInfoPtr__ctor_Internal_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSyntaxException>.NativeClassPtr, 100670785);
		}

		// Token: 0x06002F32 RID: 12082 RVA: 0x000EDE04 File Offset: 0x000EC004
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 45967, RefRangeEnd = 45968, XrefRangeStart = 45967, XrefRangeEnd = 45968, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlSyntaxException()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlSyntaxException>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSyntaxException.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002F33 RID: 12083 RVA: 0x000EDE40 File Offset: 0x000EC040
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 337824, XrefRangeEnd = 337832, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlSyntaxException(int lineNumber)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlSyntaxException>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lineNumber;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSyntaxException.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002F34 RID: 12084 RVA: 0x000EDE88 File Offset: 0x000EC088
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 337832, XrefRangeEnd = 337840, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlSyntaxException(int lineNumber, string message)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlSyntaxException>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lineNumber;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(message);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSyntaxException.NativeMethodInfoPtr__ctor_Public_Void_Int32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002F35 RID: 12085 RVA: 0x000EDEE4 File Offset: 0x000EC0E4
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 337841, RefRangeEnd = 337849, XrefRangeStart = 337840, XrefRangeEnd = 337841, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlSyntaxException(string message)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlSyntaxException>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSyntaxException.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002F36 RID: 12086 RVA: 0x000EDF30 File Offset: 0x000EC130
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlSyntaxException(string message, Exception inner)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlSyntaxException>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(inner);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSyntaxException.NativeMethodInfoPtr__ctor_Public_Void_String_Exception_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002F37 RID: 12087 RVA: 0x000EDF90 File Offset: 0x000EC190
		[CallerCount(21)]
		[CachedScanResults(RefRangeStart = 41353, RefRangeEnd = 41374, XrefRangeStart = 41353, XrefRangeEnd = 41374, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlSyntaxException(SerializationInfo info, StreamingContext context)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlSyntaxException>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSyntaxException.NativeMethodInfoPtr__ctor_Internal_Void_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002F38 RID: 12088 RVA: 0x00010780 File Offset: 0x0000E980
		public XmlSyntaxException(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040028CA RID: 10442
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040028CB RID: 10443
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		// Token: 0x040028CC RID: 10444
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_String_0;

		// Token: 0x040028CD RID: 10445
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		// Token: 0x040028CE RID: 10446
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Exception_0;

		// Token: 0x040028CF RID: 10447
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_SerializationInfo_StreamingContext_0;
	}
}
