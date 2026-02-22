using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Runtime.Serialization;

namespace Il2CppSystem.Runtime.Remoting.Messaging
{
	// Token: 0x02000404 RID: 1028
	public class RemotingSurrogate : Object
	{
		// Token: 0x060040F8 RID: 16632 RVA: 0x0012CB70 File Offset: 0x0012AD70
		// Note: this type is marked as 'beforefieldinit'.
		static RemotingSurrogate()
		{
			Il2CppClassPointerStore<RemotingSurrogate>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Remoting.Messaging", "RemotingSurrogate");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RemotingSurrogate>.NativeClassPtr);
			RemotingSurrogate.NativeMethodInfoPtr_GetObjectData_Public_Virtual_New_Void_Object_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemotingSurrogate>.NativeClassPtr, 100672772);
			RemotingSurrogate.NativeMethodInfoPtr_SetObjectData_Public_Virtual_New_Object_Object_SerializationInfo_StreamingContext_ISurrogateSelector_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemotingSurrogate>.NativeClassPtr, 100672773);
			RemotingSurrogate.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemotingSurrogate>.NativeClassPtr, 100672774);
		}

		// Token: 0x060040F9 RID: 16633 RVA: 0x0012CBDC File Offset: 0x0012ADDC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 355717, XrefRangeEnd = 355726, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void GetObjectData(Object obj, SerializationInfo si, StreamingContext sc)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(si);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(sc));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RemotingSurrogate.NativeMethodInfoPtr_GetObjectData_Public_Virtual_New_Void_Object_SerializationInfo_StreamingContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060040FA RID: 16634 RVA: 0x0012CC54 File Offset: 0x0012AE54
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 355726, XrefRangeEnd = 355731, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Object SetObjectData(Object obj, SerializationInfo si, StreamingContext sc, ISurrogateSelector selector)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(si);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(sc));
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(selector);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RemotingSurrogate.NativeMethodInfoPtr_SetObjectData_Public_Virtual_New_Object_Object_SerializationInfo_StreamingContext_ISurrogateSelector_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x060040FB RID: 16635 RVA: 0x0012CCEC File Offset: 0x0012AEEC
		[CallerCount(817)]
		[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RemotingSurrogate()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RemotingSurrogate>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RemotingSurrogate.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060040FC RID: 16636 RVA: 0x00018AB9 File Offset: 0x00016CB9
		public RemotingSurrogate(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400351F RID: 13599
		private static readonly IntPtr NativeMethodInfoPtr_GetObjectData_Public_Virtual_New_Void_Object_SerializationInfo_StreamingContext_0;

		// Token: 0x04003520 RID: 13600
		private static readonly IntPtr NativeMethodInfoPtr_SetObjectData_Public_Virtual_New_Object_Object_SerializationInfo_StreamingContext_ISurrogateSelector_0;

		// Token: 0x04003521 RID: 13601
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
