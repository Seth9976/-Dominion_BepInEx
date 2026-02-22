using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem.Runtime.Serialization;

namespace Il2CppSystem.Threading
{
	// Token: 0x0200027C RID: 636
	[Serializable]
	public class ThreadInterruptedException : SystemException
	{
		// Token: 0x06002BA4 RID: 11172 RVA: 0x000DFCDC File Offset: 0x000DDEDC
		// Note: this type is marked as 'beforefieldinit'.
		static ThreadInterruptedException()
		{
			Il2CppClassPointerStore<ThreadInterruptedException>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Threading", "ThreadInterruptedException");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ThreadInterruptedException>.NativeClassPtr);
			ThreadInterruptedException.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThreadInterruptedException>.NativeClassPtr, 100670241);
			ThreadInterruptedException.NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThreadInterruptedException>.NativeClassPtr, 100670242);
		}

		// Token: 0x06002BA5 RID: 11173 RVA: 0x000DFD34 File Offset: 0x000DDF34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 332850, XrefRangeEnd = 332873, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ThreadInterruptedException()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ThreadInterruptedException>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThreadInterruptedException.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002BA6 RID: 11174 RVA: 0x000DFD70 File Offset: 0x000DDF70
		[CallerCount(21)]
		[CachedScanResults(RefRangeStart = 41353, RefRangeEnd = 41374, XrefRangeStart = 41353, XrefRangeEnd = 41374, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ThreadInterruptedException(SerializationInfo info, StreamingContext context)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ThreadInterruptedException>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThreadInterruptedException.NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002BA7 RID: 11175 RVA: 0x0000F2DC File Offset: 0x0000D4DC
		public ThreadInterruptedException(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04002611 RID: 9745
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04002612 RID: 9746
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0;
	}
}
