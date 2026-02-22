using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Runtime.Serialization;

namespace Il2CppSystem.Runtime.Remoting.Messaging
{
	// Token: 0x02000405 RID: 1029
	public class ObjRefSurrogate : Object
	{
		// Token: 0x060040FD RID: 16637 RVA: 0x0012CD28 File Offset: 0x0012AF28
		// Note: this type is marked as 'beforefieldinit'.
		static ObjRefSurrogate()
		{
			Il2CppClassPointerStore<ObjRefSurrogate>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Remoting.Messaging", "ObjRefSurrogate");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ObjRefSurrogate>.NativeClassPtr);
			ObjRefSurrogate.NativeMethodInfoPtr_GetObjectData_Public_Virtual_New_Void_Object_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjRefSurrogate>.NativeClassPtr, 100672775);
			ObjRefSurrogate.NativeMethodInfoPtr_SetObjectData_Public_Virtual_New_Object_Object_SerializationInfo_StreamingContext_ISurrogateSelector_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjRefSurrogate>.NativeClassPtr, 100672776);
			ObjRefSurrogate.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjRefSurrogate>.NativeClassPtr, 100672777);
		}

		// Token: 0x060040FE RID: 16638 RVA: 0x0012CD94 File Offset: 0x0012AF94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 355731, XrefRangeEnd = 355742, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ObjRefSurrogate.NativeMethodInfoPtr_GetObjectData_Public_Virtual_New_Void_Object_SerializationInfo_StreamingContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060040FF RID: 16639 RVA: 0x0012CE0C File Offset: 0x0012B00C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 355742, XrefRangeEnd = 355748, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ObjRefSurrogate.NativeMethodInfoPtr_SetObjectData_Public_Virtual_New_Object_Object_SerializationInfo_StreamingContext_ISurrogateSelector_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06004100 RID: 16640 RVA: 0x0012CEA4 File Offset: 0x0012B0A4
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ObjRefSurrogate()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ObjRefSurrogate>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjRefSurrogate.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004101 RID: 16641 RVA: 0x00018AC2 File Offset: 0x00016CC2
		public ObjRefSurrogate(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04003522 RID: 13602
		private static readonly IntPtr NativeMethodInfoPtr_GetObjectData_Public_Virtual_New_Void_Object_SerializationInfo_StreamingContext_0;

		// Token: 0x04003523 RID: 13603
		private static readonly IntPtr NativeMethodInfoPtr_SetObjectData_Public_Virtual_New_Object_Object_SerializationInfo_StreamingContext_ISurrogateSelector_0;

		// Token: 0x04003524 RID: 13604
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
