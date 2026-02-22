using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;
using Il2CppSystem.Runtime.Serialization;

namespace Il2CppSystem.Runtime.Remoting.Messaging
{
	// Token: 0x020003F0 RID: 1008
	[Serializable]
	public class ConstructionResponse : MethodResponse
	{
		// Token: 0x06003FE2 RID: 16354 RVA: 0x00128AA8 File Offset: 0x00126CA8
		// Note: this type is marked as 'beforefieldinit'.
		static ConstructionResponse()
		{
			Il2CppClassPointerStore<ConstructionResponse>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Remoting.Messaging", "ConstructionResponse");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ConstructionResponse>.NativeClassPtr);
			ConstructionResponse.NativeMethodInfoPtr__ctor_Internal_Void_Object_LogicalCallContext_IMethodCallMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstructionResponse>.NativeClassPtr, 100672624);
			ConstructionResponse.NativeMethodInfoPtr__ctor_Internal_Void_Exception_IMethodCallMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstructionResponse>.NativeClassPtr, 100672625);
			ConstructionResponse.NativeMethodInfoPtr__ctor_Internal_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstructionResponse>.NativeClassPtr, 100672626);
			ConstructionResponse.NativeMethodInfoPtr_get_Properties_Public_Virtual_get_IDictionary_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstructionResponse>.NativeClassPtr, 100672627);
		}

		// Token: 0x06003FE3 RID: 16355 RVA: 0x00128B28 File Offset: 0x00126D28
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 354992, RefRangeEnd = 354995, XrefRangeStart = 354991, XrefRangeEnd = 354992, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ConstructionResponse(Object resultObject, LogicalCallContext callCtx, IMethodCallMessage msg)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ConstructionResponse>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(resultObject);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callCtx);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(msg);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConstructionResponse.NativeMethodInfoPtr__ctor_Internal_Void_Object_LogicalCallContext_IMethodCallMessage_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003FE4 RID: 16356 RVA: 0x00128B98 File Offset: 0x00126D98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 354995, XrefRangeEnd = 354996, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ConstructionResponse(Exception e, IMethodCallMessage msg)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ConstructionResponse>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(e);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(msg);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConstructionResponse.NativeMethodInfoPtr__ctor_Internal_Void_Exception_IMethodCallMessage_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003FE5 RID: 16357 RVA: 0x00128BF8 File Offset: 0x00126DF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 354996, XrefRangeEnd = 354997, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ConstructionResponse(SerializationInfo info, StreamingContext context)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ConstructionResponse>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConstructionResponse.NativeMethodInfoPtr__ctor_Internal_Void_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x1700102C RID: 4140
		// (get) Token: 0x06003FE6 RID: 16358 RVA: 0x00128C5C File Offset: 0x00126E5C
		public unsafe override IDictionary Properties
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 354997, XrefRangeEnd = 354998, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ConstructionResponse.NativeMethodInfoPtr_get_Properties_Public_Virtual_get_IDictionary_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IDictionary>(intPtr3) : null;
			}
		}

		// Token: 0x06003FE7 RID: 16359 RVA: 0x00018380 File Offset: 0x00016580
		public ConstructionResponse(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400345F RID: 13407
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Object_LogicalCallContext_IMethodCallMessage_0;

		// Token: 0x04003460 RID: 13408
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Exception_IMethodCallMessage_0;

		// Token: 0x04003461 RID: 13409
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_SerializationInfo_StreamingContext_0;

		// Token: 0x04003462 RID: 13410
		private static readonly IntPtr NativeMethodInfoPtr_get_Properties_Public_Virtual_get_IDictionary_0;
	}
}
