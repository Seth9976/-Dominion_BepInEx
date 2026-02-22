using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem.Runtime.Serialization;

namespace Il2CppSystem.Reflection
{
	// Token: 0x020001BA RID: 442
	[Serializable]
	public sealed class TargetInvocationException : ApplicationException
	{
		// Token: 0x06001C49 RID: 7241 RVA: 0x000A1258 File Offset: 0x0009F458
		// Note: this type is marked as 'beforefieldinit'.
		static TargetInvocationException()
		{
			Il2CppClassPointerStore<TargetInvocationException>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Reflection", "TargetInvocationException");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TargetInvocationException>.NativeClassPtr);
			TargetInvocationException.NativeMethodInfoPtr__ctor_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TargetInvocationException>.NativeClassPtr, 100668014);
			TargetInvocationException.NativeMethodInfoPtr__ctor_Public_Void_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TargetInvocationException>.NativeClassPtr, 100668015);
			TargetInvocationException.NativeMethodInfoPtr__ctor_Public_Void_String_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TargetInvocationException>.NativeClassPtr, 100668016);
			TargetInvocationException.NativeMethodInfoPtr__ctor_Internal_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TargetInvocationException>.NativeClassPtr, 100668017);
		}

		// Token: 0x06001C4A RID: 7242 RVA: 0x000A12D8 File Offset: 0x0009F4D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 317339, XrefRangeEnd = 317344, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TargetInvocationException()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TargetInvocationException>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TargetInvocationException.NativeMethodInfoPtr__ctor_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001C4B RID: 7243 RVA: 0x000A1314 File Offset: 0x0009F514
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 317344, XrefRangeEnd = 317349, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TargetInvocationException(Exception inner)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TargetInvocationException>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(inner);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TargetInvocationException.NativeMethodInfoPtr__ctor_Public_Void_Exception_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001C4C RID: 7244 RVA: 0x000A1360 File Offset: 0x0009F560
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 317349, XrefRangeEnd = 317351, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TargetInvocationException(string message, Exception inner)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TargetInvocationException>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(inner);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TargetInvocationException.NativeMethodInfoPtr__ctor_Public_Void_String_Exception_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001C4D RID: 7245 RVA: 0x000A13C0 File Offset: 0x0009F5C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TargetInvocationException(SerializationInfo info, StreamingContext context)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TargetInvocationException>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TargetInvocationException.NativeMethodInfoPtr__ctor_Internal_Void_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001C4E RID: 7246 RVA: 0x00009BFB File Offset: 0x00007DFB
		public TargetInvocationException(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04001A05 RID: 6661
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_0;

		// Token: 0x04001A06 RID: 6662
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Exception_0;

		// Token: 0x04001A07 RID: 6663
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Exception_0;

		// Token: 0x04001A08 RID: 6664
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_SerializationInfo_StreamingContext_0;
	}
}
