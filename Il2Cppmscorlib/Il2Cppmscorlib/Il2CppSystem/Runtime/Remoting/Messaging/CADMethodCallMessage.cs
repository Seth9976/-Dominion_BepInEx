using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;

namespace Il2CppSystem.Runtime.Remoting.Messaging
{
	// Token: 0x020003EA RID: 1002
	public class CADMethodCallMessage : CADMessageBase
	{
		// Token: 0x06003F91 RID: 16273 RVA: 0x00127738 File Offset: 0x00125938
		// Note: this type is marked as 'beforefieldinit'.
		static CADMethodCallMessage()
		{
			Il2CppClassPointerStore<CADMethodCallMessage>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Remoting.Messaging", "CADMethodCallMessage");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CADMethodCallMessage>.NativeClassPtr);
			CADMethodCallMessage.NativeFieldInfoPtr__uri = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CADMethodCallMessage>.NativeClassPtr, "_uri");
			CADMethodCallMessage.NativeMethodInfoPtr_get_Uri_Internal_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CADMethodCallMessage>.NativeClassPtr, 100672584);
			CADMethodCallMessage.NativeMethodInfoPtr_Create_Internal_Static_CADMethodCallMessage_IMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CADMethodCallMessage>.NativeClassPtr, 100672585);
			CADMethodCallMessage.NativeMethodInfoPtr__ctor_Internal_Void_IMethodCallMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CADMethodCallMessage>.NativeClassPtr, 100672586);
			CADMethodCallMessage.NativeMethodInfoPtr_GetArguments_Internal_ArrayList_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CADMethodCallMessage>.NativeClassPtr, 100672587);
			CADMethodCallMessage.NativeMethodInfoPtr_GetArgs_Internal_Il2CppReferenceArray_1_Object_ArrayList_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CADMethodCallMessage>.NativeClassPtr, 100672588);
			CADMethodCallMessage.NativeMethodInfoPtr_get_PropertiesCount_Internal_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CADMethodCallMessage>.NativeClassPtr, 100672589);
		}

		// Token: 0x17001013 RID: 4115
		// (get) Token: 0x06003F92 RID: 16274 RVA: 0x001277F4 File Offset: 0x001259F4
		public unsafe string Uri
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CADMethodCallMessage.NativeMethodInfoPtr_get_Uri_Internal_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06003F93 RID: 16275 RVA: 0x0012782C File Offset: 0x00125A2C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 354591, RefRangeEnd = 354592, XrefRangeStart = 354584, XrefRangeEnd = 354591, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static CADMethodCallMessage Create(IMessage callMsg)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(callMsg);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CADMethodCallMessage.NativeMethodInfoPtr_Create_Internal_Static_CADMethodCallMessage_IMessage_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<CADMethodCallMessage>(intPtr3) : null;
			}
		}

		// Token: 0x06003F94 RID: 16276 RVA: 0x00127870 File Offset: 0x00125A70
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 354622, RefRangeEnd = 354623, XrefRangeStart = 354592, XrefRangeEnd = 354622, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CADMethodCallMessage(IMethodCallMessage callMsg)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CADMethodCallMessage>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(callMsg);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CADMethodCallMessage.NativeMethodInfoPtr__ctor_Internal_Void_IMethodCallMessage_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003F95 RID: 16277 RVA: 0x001278BC File Offset: 0x00125ABC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 354636, RefRangeEnd = 354637, XrefRangeStart = 354623, XrefRangeEnd = 354636, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ArrayList GetArguments()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CADMethodCallMessage.NativeMethodInfoPtr_GetArguments_Internal_ArrayList_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ArrayList>(intPtr3) : null;
		}

		// Token: 0x06003F96 RID: 16278 RVA: 0x001278FC File Offset: 0x00125AFC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 354638, RefRangeEnd = 354640, XrefRangeStart = 354637, XrefRangeEnd = 354638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppReferenceArray<Object> GetArgs(ArrayList args)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(args);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CADMethodCallMessage.NativeMethodInfoPtr_GetArgs_Internal_Il2CppReferenceArray_1_Object_ArrayList_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Object>>(intPtr3) : null;
			}
		}

		// Token: 0x17001014 RID: 4116
		// (get) Token: 0x06003F97 RID: 16279 RVA: 0x0012794C File Offset: 0x00125B4C
		public unsafe int PropertiesCount
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CADMethodCallMessage.NativeMethodInfoPtr_get_PropertiesCount_Internal_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06003F98 RID: 16280 RVA: 0x0001818A File Offset: 0x0001638A
		public CADMethodCallMessage(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17001012 RID: 4114
		// (get) Token: 0x06003F99 RID: 16281 RVA: 0x00127988 File Offset: 0x00125B88
		// (set) Token: 0x06003F9A RID: 16282 RVA: 0x00018193 File Offset: 0x00016393
		public unsafe string _uri
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CADMethodCallMessage.NativeFieldInfoPtr__uri);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CADMethodCallMessage.NativeFieldInfoPtr__uri), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04003429 RID: 13353
		private static readonly IntPtr NativeFieldInfoPtr__uri;

		// Token: 0x0400342A RID: 13354
		private static readonly IntPtr NativeMethodInfoPtr_get_Uri_Internal_get_String_0;

		// Token: 0x0400342B RID: 13355
		private static readonly IntPtr NativeMethodInfoPtr_Create_Internal_Static_CADMethodCallMessage_IMessage_0;

		// Token: 0x0400342C RID: 13356
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_IMethodCallMessage_0;

		// Token: 0x0400342D RID: 13357
		private static readonly IntPtr NativeMethodInfoPtr_GetArguments_Internal_ArrayList_0;

		// Token: 0x0400342E RID: 13358
		private static readonly IntPtr NativeMethodInfoPtr_GetArgs_Internal_Il2CppReferenceArray_1_Object_ArrayList_0;

		// Token: 0x0400342F RID: 13359
		private static readonly IntPtr NativeMethodInfoPtr_get_PropertiesCount_Internal_get_Int32_0;
	}
}
