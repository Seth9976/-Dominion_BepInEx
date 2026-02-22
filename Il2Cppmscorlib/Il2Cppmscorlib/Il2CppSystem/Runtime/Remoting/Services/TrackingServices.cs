using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;

namespace Il2CppSystem.Runtime.Remoting.Services
{
	// Token: 0x020003A8 RID: 936
	public class TrackingServices : Object
	{
		// Token: 0x06003CD8 RID: 15576 RVA: 0x0011E090 File Offset: 0x0011C290
		// Note: this type is marked as 'beforefieldinit'.
		static TrackingServices()
		{
			Il2CppClassPointerStore<TrackingServices>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Remoting.Services", "TrackingServices");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TrackingServices>.NativeClassPtr);
			TrackingServices.NativeFieldInfoPtr__handlers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrackingServices>.NativeClassPtr, "_handlers");
			TrackingServices.NativeMethodInfoPtr_NotifyMarshaledObject_Internal_Static_Void_Object_ObjRef_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrackingServices>.NativeClassPtr, 100672263);
			TrackingServices.NativeMethodInfoPtr_NotifyUnmarshaledObject_Internal_Static_Void_Object_ObjRef_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrackingServices>.NativeClassPtr, 100672264);
			TrackingServices.NativeMethodInfoPtr_NotifyDisconnectedObject_Internal_Static_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrackingServices>.NativeClassPtr, 100672265);
		}

		// Token: 0x06003CD9 RID: 15577 RVA: 0x0011E110 File Offset: 0x0011C310
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 351460, XrefRangeEnd = 351489, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void NotifyMarshaledObject(Object obj, ObjRef or)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(or);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrackingServices.NativeMethodInfoPtr_NotifyMarshaledObject_Internal_Static_Void_Object_ObjRef_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003CDA RID: 15578 RVA: 0x0011E158 File Offset: 0x0011C358
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 351518, RefRangeEnd = 351519, XrefRangeStart = 351489, XrefRangeEnd = 351518, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void NotifyUnmarshaledObject(Object obj, ObjRef or)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(or);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrackingServices.NativeMethodInfoPtr_NotifyUnmarshaledObject_Internal_Static_Void_Object_ObjRef_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003CDB RID: 15579 RVA: 0x0011E1A0 File Offset: 0x0011C3A0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 351548, RefRangeEnd = 351549, XrefRangeStart = 351519, XrefRangeEnd = 351548, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void NotifyDisconnectedObject(Object obj)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrackingServices.NativeMethodInfoPtr_NotifyDisconnectedObject_Internal_Static_Void_Object_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003CDC RID: 15580 RVA: 0x00016E60 File Offset: 0x00015060
		public TrackingServices(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000F3C RID: 3900
		// (get) Token: 0x06003CDD RID: 15581 RVA: 0x0011E1D8 File Offset: 0x0011C3D8
		// (set) Token: 0x06003CDE RID: 15582 RVA: 0x00016E69 File Offset: 0x00015069
		public unsafe static ArrayList _handlers
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TrackingServices.NativeFieldInfoPtr__handlers, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArrayList>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TrackingServices.NativeFieldInfoPtr__handlers, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400326F RID: 12911
		private static readonly IntPtr NativeFieldInfoPtr__handlers;

		// Token: 0x04003270 RID: 12912
		private static readonly IntPtr NativeMethodInfoPtr_NotifyMarshaledObject_Internal_Static_Void_Object_ObjRef_0;

		// Token: 0x04003271 RID: 12913
		private static readonly IntPtr NativeMethodInfoPtr_NotifyUnmarshaledObject_Internal_Static_Void_Object_ObjRef_0;

		// Token: 0x04003272 RID: 12914
		private static readonly IntPtr NativeMethodInfoPtr_NotifyDisconnectedObject_Internal_Static_Void_Object_0;
	}
}
