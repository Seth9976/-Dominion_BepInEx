using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem.Runtime.Serialization;

namespace Il2CppSystem
{
	// Token: 0x02000078 RID: 120
	[Serializable]
	public class ArithmeticException : SystemException
	{
		// Token: 0x0600072C RID: 1836 RVA: 0x000422A8 File Offset: 0x000404A8
		// Note: this type is marked as 'beforefieldinit'.
		static ArithmeticException()
		{
			Il2CppClassPointerStore<ArithmeticException>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "ArithmeticException");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ArithmeticException>.NativeClassPtr);
			ArithmeticException.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArithmeticException>.NativeClassPtr, 100664409);
			ArithmeticException.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArithmeticException>.NativeClassPtr, 100664410);
			ArithmeticException.NativeMethodInfoPtr__ctor_Public_Void_String_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArithmeticException>.NativeClassPtr, 100664411);
			ArithmeticException.NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArithmeticException>.NativeClassPtr, 100664412);
		}

		// Token: 0x0600072D RID: 1837 RVA: 0x00042328 File Offset: 0x00040528
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 276230, XrefRangeEnd = 276235, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ArithmeticException()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ArithmeticException>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArithmeticException.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600072E RID: 1838 RVA: 0x00042364 File Offset: 0x00040564
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 276237, RefRangeEnd = 276240, XrefRangeStart = 276235, XrefRangeEnd = 276237, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ArithmeticException(string message)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ArithmeticException>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArithmeticException.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600072F RID: 1839 RVA: 0x000423B0 File Offset: 0x000405B0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 276242, RefRangeEnd = 276243, XrefRangeStart = 276240, XrefRangeEnd = 276242, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ArithmeticException(string message, Exception innerException)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ArithmeticException>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(innerException);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArithmeticException.NativeMethodInfoPtr__ctor_Public_Void_String_Exception_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000730 RID: 1840 RVA: 0x00042410 File Offset: 0x00040610
		[CallerCount(21)]
		[CachedScanResults(RefRangeStart = 41353, RefRangeEnd = 41374, XrefRangeStart = 41353, XrefRangeEnd = 41374, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ArithmeticException(SerializationInfo info, StreamingContext context)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ArithmeticException>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArithmeticException.NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000731 RID: 1841 RVA: 0x000044FF File Offset: 0x000026FF
		public ArithmeticException(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000521 RID: 1313
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000522 RID: 1314
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		// Token: 0x04000523 RID: 1315
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Exception_0;

		// Token: 0x04000524 RID: 1316
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0;
	}
}
