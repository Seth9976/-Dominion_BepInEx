using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem.Runtime.Serialization;

namespace Il2CppSystem.Diagnostics.Tracing
{
	// Token: 0x02000523 RID: 1315
	[Serializable]
	public class EventSourceException : Exception
	{
		// Token: 0x06004C16 RID: 19478 RVA: 0x0015B118 File Offset: 0x00159318
		// Note: this type is marked as 'beforefieldinit'.
		static EventSourceException()
		{
			Il2CppClassPointerStore<EventSourceException>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Diagnostics.Tracing", "EventSourceException");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EventSourceException>.NativeClassPtr);
			EventSourceException.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventSourceException>.NativeClassPtr, 100674539);
			EventSourceException.NativeMethodInfoPtr__ctor_Public_Void_String_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventSourceException>.NativeClassPtr, 100674540);
			EventSourceException.NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventSourceException>.NativeClassPtr, 100674541);
			EventSourceException.NativeMethodInfoPtr__ctor_Internal_Void_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventSourceException>.NativeClassPtr, 100674542);
		}

		// Token: 0x06004C17 RID: 19479 RVA: 0x0015B198 File Offset: 0x00159398
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 375046, XrefRangeEnd = 375057, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EventSourceException()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EventSourceException>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventSourceException.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004C18 RID: 19480 RVA: 0x0015B1D4 File Offset: 0x001593D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 375057, XrefRangeEnd = 375061, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EventSourceException(string message, Exception innerException)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EventSourceException>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(innerException);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventSourceException.NativeMethodInfoPtr__ctor_Public_Void_String_Exception_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004C19 RID: 19481 RVA: 0x0015B234 File Offset: 0x00159434
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 375061, XrefRangeEnd = 375065, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EventSourceException(SerializationInfo info, StreamingContext context)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EventSourceException>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventSourceException.NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004C1A RID: 19482 RVA: 0x0015B298 File Offset: 0x00159498
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 375065, XrefRangeEnd = 375072, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EventSourceException(Exception innerException)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EventSourceException>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(innerException);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventSourceException.NativeMethodInfoPtr__ctor_Internal_Void_Exception_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06004C1B RID: 19483 RVA: 0x0001CB23 File Offset: 0x0001AD23
		public EventSourceException(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04003D6B RID: 15723
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04003D6C RID: 15724
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Exception_0;

		// Token: 0x04003D6D RID: 15725
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0;

		// Token: 0x04003D6E RID: 15726
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Exception_0;
	}
}
