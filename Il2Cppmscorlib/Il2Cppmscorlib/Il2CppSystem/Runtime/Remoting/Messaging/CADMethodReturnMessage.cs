using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;

namespace Il2CppSystem.Runtime.Remoting.Messaging
{
	// Token: 0x020003EB RID: 1003
	public class CADMethodReturnMessage : CADMessageBase
	{
		// Token: 0x06003F9B RID: 16283 RVA: 0x001279B0 File Offset: 0x00125BB0
		// Note: this type is marked as 'beforefieldinit'.
		static CADMethodReturnMessage()
		{
			Il2CppClassPointerStore<CADMethodReturnMessage>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Remoting.Messaging", "CADMethodReturnMessage");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CADMethodReturnMessage>.NativeClassPtr);
			CADMethodReturnMessage.NativeFieldInfoPtr__returnValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CADMethodReturnMessage>.NativeClassPtr, "_returnValue");
			CADMethodReturnMessage.NativeFieldInfoPtr__exception = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CADMethodReturnMessage>.NativeClassPtr, "_exception");
			CADMethodReturnMessage.NativeFieldInfoPtr__sig = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CADMethodReturnMessage>.NativeClassPtr, "_sig");
			CADMethodReturnMessage.NativeMethodInfoPtr_Create_Internal_Static_CADMethodReturnMessage_IMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CADMethodReturnMessage>.NativeClassPtr, 100672590);
			CADMethodReturnMessage.NativeMethodInfoPtr__ctor_Internal_Void_IMethodReturnMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CADMethodReturnMessage>.NativeClassPtr, 100672591);
			CADMethodReturnMessage.NativeMethodInfoPtr_GetArguments_Internal_ArrayList_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CADMethodReturnMessage>.NativeClassPtr, 100672592);
			CADMethodReturnMessage.NativeMethodInfoPtr_GetArgs_Internal_Il2CppReferenceArray_1_Object_ArrayList_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CADMethodReturnMessage>.NativeClassPtr, 100672593);
			CADMethodReturnMessage.NativeMethodInfoPtr_GetReturnValue_Internal_Object_ArrayList_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CADMethodReturnMessage>.NativeClassPtr, 100672594);
			CADMethodReturnMessage.NativeMethodInfoPtr_GetException_Internal_Exception_ArrayList_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CADMethodReturnMessage>.NativeClassPtr, 100672595);
			CADMethodReturnMessage.NativeMethodInfoPtr_get_PropertiesCount_Internal_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CADMethodReturnMessage>.NativeClassPtr, 100672596);
		}

		// Token: 0x06003F9C RID: 16284 RVA: 0x00127AA8 File Offset: 0x00125CA8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 354647, RefRangeEnd = 354648, XrefRangeStart = 354640, XrefRangeEnd = 354647, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static CADMethodReturnMessage Create(IMessage callMsg)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(callMsg);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CADMethodReturnMessage.NativeMethodInfoPtr_Create_Internal_Static_CADMethodReturnMessage_IMessage_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<CADMethodReturnMessage>(intPtr3) : null;
			}
		}

		// Token: 0x06003F9D RID: 16285 RVA: 0x00127AEC File Offset: 0x00125CEC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 354688, RefRangeEnd = 354689, XrefRangeStart = 354648, XrefRangeEnd = 354688, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CADMethodReturnMessage(IMethodReturnMessage retMsg)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CADMethodReturnMessage>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(retMsg);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CADMethodReturnMessage.NativeMethodInfoPtr__ctor_Internal_Void_IMethodReturnMessage_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003F9E RID: 16286 RVA: 0x00127B38 File Offset: 0x00125D38
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 354702, RefRangeEnd = 354703, XrefRangeStart = 354689, XrefRangeEnd = 354702, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ArrayList GetArguments()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CADMethodReturnMessage.NativeMethodInfoPtr_GetArguments_Internal_ArrayList_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ArrayList>(intPtr3) : null;
		}

		// Token: 0x06003F9F RID: 16287 RVA: 0x00127B78 File Offset: 0x00125D78
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 354638, RefRangeEnd = 354640, XrefRangeStart = 354638, XrefRangeEnd = 354640, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppReferenceArray<Object> GetArgs(ArrayList args)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(args);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CADMethodReturnMessage.NativeMethodInfoPtr_GetArgs_Internal_Il2CppReferenceArray_1_Object_ArrayList_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Object>>(intPtr3) : null;
			}
		}

		// Token: 0x06003FA0 RID: 16288 RVA: 0x00127BC8 File Offset: 0x00125DC8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 354704, RefRangeEnd = 354705, XrefRangeStart = 354703, XrefRangeEnd = 354704, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object GetReturnValue(ArrayList args)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(args);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CADMethodReturnMessage.NativeMethodInfoPtr_GetReturnValue_Internal_Object_ArrayList_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x06003FA1 RID: 16289 RVA: 0x00127C18 File Offset: 0x00125E18
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 354707, RefRangeEnd = 354708, XrefRangeStart = 354705, XrefRangeEnd = 354707, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Exception GetException(ArrayList args)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(args);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CADMethodReturnMessage.NativeMethodInfoPtr_GetException_Internal_Exception_ArrayList_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
			}
		}

		// Token: 0x17001018 RID: 4120
		// (get) Token: 0x06003FA2 RID: 16290 RVA: 0x00127C68 File Offset: 0x00125E68
		public unsafe int PropertiesCount
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CADMethodReturnMessage.NativeMethodInfoPtr_get_PropertiesCount_Internal_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06003FA3 RID: 16291 RVA: 0x000181B2 File Offset: 0x000163B2
		public CADMethodReturnMessage(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17001015 RID: 4117
		// (get) Token: 0x06003FA4 RID: 16292 RVA: 0x00127CA4 File Offset: 0x00125EA4
		// (set) Token: 0x06003FA5 RID: 16293 RVA: 0x000181BB File Offset: 0x000163BB
		public unsafe Object _returnValue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CADMethodReturnMessage.NativeFieldInfoPtr__returnValue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CADMethodReturnMessage.NativeFieldInfoPtr__returnValue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001016 RID: 4118
		// (get) Token: 0x06003FA6 RID: 16294 RVA: 0x00127CD4 File Offset: 0x00125ED4
		// (set) Token: 0x06003FA7 RID: 16295 RVA: 0x000181DA File Offset: 0x000163DA
		public unsafe CADArgHolder _exception
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CADMethodReturnMessage.NativeFieldInfoPtr__exception);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CADArgHolder>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CADMethodReturnMessage.NativeFieldInfoPtr__exception), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001017 RID: 4119
		// (get) Token: 0x06003FA8 RID: 16296 RVA: 0x00127D04 File Offset: 0x00125F04
		// (set) Token: 0x06003FA9 RID: 16297 RVA: 0x000181F9 File Offset: 0x000163F9
		public unsafe Il2CppReferenceArray<Type> _sig
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CADMethodReturnMessage.NativeFieldInfoPtr__sig);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Type>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CADMethodReturnMessage.NativeFieldInfoPtr__sig), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04003430 RID: 13360
		private static readonly IntPtr NativeFieldInfoPtr__returnValue;

		// Token: 0x04003431 RID: 13361
		private static readonly IntPtr NativeFieldInfoPtr__exception;

		// Token: 0x04003432 RID: 13362
		private static readonly IntPtr NativeFieldInfoPtr__sig;

		// Token: 0x04003433 RID: 13363
		private static readonly IntPtr NativeMethodInfoPtr_Create_Internal_Static_CADMethodReturnMessage_IMessage_0;

		// Token: 0x04003434 RID: 13364
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_IMethodReturnMessage_0;

		// Token: 0x04003435 RID: 13365
		private static readonly IntPtr NativeMethodInfoPtr_GetArguments_Internal_ArrayList_0;

		// Token: 0x04003436 RID: 13366
		private static readonly IntPtr NativeMethodInfoPtr_GetArgs_Internal_Il2CppReferenceArray_1_Object_ArrayList_0;

		// Token: 0x04003437 RID: 13367
		private static readonly IntPtr NativeMethodInfoPtr_GetReturnValue_Internal_Object_ArrayList_0;

		// Token: 0x04003438 RID: 13368
		private static readonly IntPtr NativeMethodInfoPtr_GetException_Internal_Exception_ArrayList_0;

		// Token: 0x04003439 RID: 13369
		private static readonly IntPtr NativeMethodInfoPtr_get_PropertiesCount_Internal_get_Int32_0;
	}
}
