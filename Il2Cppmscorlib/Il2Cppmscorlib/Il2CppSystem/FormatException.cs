using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem.Runtime.Serialization;

namespace Il2CppSystem
{
	// Token: 0x020000A7 RID: 167
	[Serializable]
	public class FormatException : SystemException
	{
		// Token: 0x06000BBC RID: 3004 RVA: 0x00056E24 File Offset: 0x00055024
		// Note: this type is marked as 'beforefieldinit'.
		static FormatException()
		{
			Il2CppClassPointerStore<FormatException>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "FormatException");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FormatException>.NativeClassPtr);
			FormatException.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FormatException>.NativeClassPtr, 100665266);
			FormatException.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FormatException>.NativeClassPtr, 100665267);
			FormatException.NativeMethodInfoPtr__ctor_Public_Void_String_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FormatException>.NativeClassPtr, 100665268);
			FormatException.NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FormatException>.NativeClassPtr, 100665269);
		}

		// Token: 0x06000BBD RID: 3005 RVA: 0x00056EA4 File Offset: 0x000550A4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 283569, RefRangeEnd = 283572, XrefRangeStart = 283565, XrefRangeEnd = 283569, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FormatException()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FormatException>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FormatException.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000BBE RID: 3006 RVA: 0x00056EE0 File Offset: 0x000550E0
		[CallerCount(19)]
		[CachedScanResults(RefRangeStart = 283573, RefRangeEnd = 283592, XrefRangeStart = 283572, XrefRangeEnd = 283573, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FormatException(string message)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FormatException>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FormatException.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000BBF RID: 3007 RVA: 0x00056F2C File Offset: 0x0005512C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 283593, RefRangeEnd = 283594, XrefRangeStart = 283592, XrefRangeEnd = 283593, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FormatException(string message, Exception innerException)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FormatException>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(innerException);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FormatException.NativeMethodInfoPtr__ctor_Public_Void_String_Exception_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000BC0 RID: 3008 RVA: 0x00056F8C File Offset: 0x0005518C
		[CallerCount(21)]
		[CachedScanResults(RefRangeStart = 41353, RefRangeEnd = 41374, XrefRangeStart = 41353, XrefRangeEnd = 41374, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FormatException(SerializationInfo info, StreamingContext context)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FormatException>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FormatException.NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000BC1 RID: 3009 RVA: 0x000050EF File Offset: 0x000032EF
		public FormatException(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040009BE RID: 2494
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040009BF RID: 2495
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		// Token: 0x040009C0 RID: 2496
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Exception_0;

		// Token: 0x040009C1 RID: 2497
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0;
	}
}
