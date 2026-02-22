using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem.Runtime.Serialization;

namespace Il2CppSystem
{
	// Token: 0x020000A4 RID: 164
	[Serializable]
	public sealed class ExecutionEngineException : SystemException
	{
		// Token: 0x06000BAE RID: 2990 RVA: 0x00056AC4 File Offset: 0x00054CC4
		// Note: this type is marked as 'beforefieldinit'.
		static ExecutionEngineException()
		{
			Il2CppClassPointerStore<ExecutionEngineException>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "ExecutionEngineException");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ExecutionEngineException>.NativeClassPtr);
			ExecutionEngineException.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExecutionEngineException>.NativeClassPtr, 100665258);
			ExecutionEngineException.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExecutionEngineException>.NativeClassPtr, 100665259);
			ExecutionEngineException.NativeMethodInfoPtr__ctor_Public_Void_String_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExecutionEngineException>.NativeClassPtr, 100665260);
			ExecutionEngineException.NativeMethodInfoPtr__ctor_Internal_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExecutionEngineException>.NativeClassPtr, 100665261);
		}

		// Token: 0x06000BAF RID: 2991 RVA: 0x00056B44 File Offset: 0x00054D44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 283552, XrefRangeEnd = 283556, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ExecutionEngineException()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ExecutionEngineException>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExecutionEngineException.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000BB0 RID: 2992 RVA: 0x00056B80 File Offset: 0x00054D80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 283556, XrefRangeEnd = 283557, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ExecutionEngineException(string message)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ExecutionEngineException>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExecutionEngineException.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000BB1 RID: 2993 RVA: 0x00056BCC File Offset: 0x00054DCC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 283558, RefRangeEnd = 283559, XrefRangeStart = 283557, XrefRangeEnd = 283558, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ExecutionEngineException(string message, Exception innerException)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ExecutionEngineException>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(innerException);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExecutionEngineException.NativeMethodInfoPtr__ctor_Public_Void_String_Exception_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000BB2 RID: 2994 RVA: 0x00056C2C File Offset: 0x00054E2C
		[CallerCount(21)]
		[CachedScanResults(RefRangeStart = 41353, RefRangeEnd = 41374, XrefRangeStart = 41353, XrefRangeEnd = 41374, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ExecutionEngineException(SerializationInfo info, StreamingContext context)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ExecutionEngineException>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExecutionEngineException.NativeMethodInfoPtr__ctor_Internal_Void_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000BB3 RID: 2995 RVA: 0x0000509B File Offset: 0x0000329B
		public ExecutionEngineException(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040009B6 RID: 2486
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040009B7 RID: 2487
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		// Token: 0x040009B8 RID: 2488
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Exception_0;

		// Token: 0x040009B9 RID: 2489
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_SerializationInfo_StreamingContext_0;
	}
}
