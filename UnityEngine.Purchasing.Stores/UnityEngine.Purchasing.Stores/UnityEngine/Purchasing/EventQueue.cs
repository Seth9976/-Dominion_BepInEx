using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Uniject;

namespace UnityEngine.Purchasing
{
	// Token: 0x02000055 RID: 85
	public class EventQueue : Object
	{
		// Token: 0x060002E5 RID: 741 RVA: 0x0000F818 File Offset: 0x0000DA18
		// Note: this type is marked as 'beforefieldinit'.
		static EventQueue()
		{
			Il2CppClassPointerStore<EventQueue>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.Purchasing.Stores.dll", "UnityEngine.Purchasing", "EventQueue");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EventQueue>.NativeClassPtr);
			EventQueue.NativeFieldInfoPtr_m_AsyncUtil = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventQueue>.NativeClassPtr, "m_AsyncUtil");
			EventQueue.NativeFieldInfoPtr_QueueInstance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventQueue>.NativeClassPtr, "QueueInstance");
			EventQueue.NativeFieldInfoPtr_Profile = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventQueue>.NativeClassPtr, "Profile");
			EventQueue.NativeFieldInfoPtr_TrackingUrl = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventQueue>.NativeClassPtr, "TrackingUrl");
			EventQueue.NativeFieldInfoPtr_EventUrl = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventQueue>.NativeClassPtr, "EventUrl");
			EventQueue.NativeFieldInfoPtr_ProfileDict = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventQueue>.NativeClassPtr, "ProfileDict");
			EventQueue.NativeMethodInfoPtr__ctor_Private_Void_IUtil_IAsyncWebUtil_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventQueue>.NativeClassPtr, 100663666);
			EventQueue.NativeMethodInfoPtr_Instance_Public_Static_EventQueue_IUtil_IAsyncWebUtil_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventQueue>.NativeClassPtr, 100663667);
			EventQueue.NativeMethodInfoPtr_SetAdsUrl_Internal_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventQueue>.NativeClassPtr, 100663668);
			EventQueue.NativeMethodInfoPtr_SetIapUrl_Internal_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventQueue>.NativeClassPtr, 100663669);
		}

		// Token: 0x060002E6 RID: 742 RVA: 0x0000F910 File Offset: 0x0000DB10
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 154075, RefRangeEnd = 154076, XrefRangeStart = 154041, XrefRangeEnd = 154075, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EventQueue(IUtil util, IAsyncWebUtil webUtil)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EventQueue>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(util);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(webUtil);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventQueue.NativeMethodInfoPtr__ctor_Private_Void_IUtil_IAsyncWebUtil_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002E7 RID: 743 RVA: 0x0000F970 File Offset: 0x0000DB70
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 154082, RefRangeEnd = 154085, XrefRangeStart = 154076, XrefRangeEnd = 154082, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static EventQueue Instance(IUtil util, IAsyncWebUtil webUtil)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(util);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(webUtil);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventQueue.NativeMethodInfoPtr_Instance_Public_Static_EventQueue_IUtil_IAsyncWebUtil_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<EventQueue>(intPtr3) : null;
		}

		// Token: 0x060002E8 RID: 744 RVA: 0x0000F9C8 File Offset: 0x0000DBC8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 14770, RefRangeEnd = 14771, XrefRangeStart = 14770, XrefRangeEnd = 14771, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetAdsUrl(string url)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(url);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventQueue.NativeMethodInfoPtr_SetAdsUrl_Internal_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060002E9 RID: 745 RVA: 0x0000FA0C File Offset: 0x0000DC0C
		[CallerCount(0)]
		public unsafe void SetIapUrl(string url)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(url);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventQueue.NativeMethodInfoPtr_SetIapUrl_Internal_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060002EA RID: 746 RVA: 0x000036B6 File Offset: 0x000018B6
		public EventQueue(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000A2 RID: 162
		// (get) Token: 0x060002EB RID: 747 RVA: 0x0000FA50 File Offset: 0x0000DC50
		// (set) Token: 0x060002EC RID: 748 RVA: 0x000036BF File Offset: 0x000018BF
		public unsafe IAsyncWebUtil m_AsyncUtil
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventQueue.NativeFieldInfoPtr_m_AsyncUtil);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IAsyncWebUtil>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventQueue.NativeFieldInfoPtr_m_AsyncUtil), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000A3 RID: 163
		// (get) Token: 0x060002ED RID: 749 RVA: 0x0000FA80 File Offset: 0x0000DC80
		// (set) Token: 0x060002EE RID: 750 RVA: 0x000036DE File Offset: 0x000018DE
		public unsafe static EventQueue QueueInstance
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(EventQueue.NativeFieldInfoPtr_QueueInstance, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EventQueue>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(EventQueue.NativeFieldInfoPtr_QueueInstance, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000A4 RID: 164
		// (get) Token: 0x060002EF RID: 751 RVA: 0x0000FAA8 File Offset: 0x0000DCA8
		// (set) Token: 0x060002F0 RID: 752 RVA: 0x000036F0 File Offset: 0x000018F0
		public unsafe ProfileData Profile
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventQueue.NativeFieldInfoPtr_Profile);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ProfileData>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventQueue.NativeFieldInfoPtr_Profile), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000A5 RID: 165
		// (get) Token: 0x060002F1 RID: 753 RVA: 0x0000FAD8 File Offset: 0x0000DCD8
		// (set) Token: 0x060002F2 RID: 754 RVA: 0x0000370F File Offset: 0x0000190F
		public unsafe string TrackingUrl
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventQueue.NativeFieldInfoPtr_TrackingUrl);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventQueue.NativeFieldInfoPtr_TrackingUrl), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170000A6 RID: 166
		// (get) Token: 0x060002F3 RID: 755 RVA: 0x0000FB00 File Offset: 0x0000DD00
		// (set) Token: 0x060002F4 RID: 756 RVA: 0x0000372E File Offset: 0x0000192E
		public unsafe string EventUrl
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventQueue.NativeFieldInfoPtr_EventUrl);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventQueue.NativeFieldInfoPtr_EventUrl), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170000A7 RID: 167
		// (get) Token: 0x060002F5 RID: 757 RVA: 0x0000FB28 File Offset: 0x0000DD28
		// (set) Token: 0x060002F6 RID: 758 RVA: 0x0000374D File Offset: 0x0000194D
		public unsafe Object ProfileDict
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventQueue.NativeFieldInfoPtr_ProfileDict);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventQueue.NativeFieldInfoPtr_ProfileDict), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040001C5 RID: 453
		private static readonly IntPtr NativeFieldInfoPtr_m_AsyncUtil;

		// Token: 0x040001C6 RID: 454
		private static readonly IntPtr NativeFieldInfoPtr_QueueInstance;

		// Token: 0x040001C7 RID: 455
		private static readonly IntPtr NativeFieldInfoPtr_Profile;

		// Token: 0x040001C8 RID: 456
		private static readonly IntPtr NativeFieldInfoPtr_TrackingUrl;

		// Token: 0x040001C9 RID: 457
		private static readonly IntPtr NativeFieldInfoPtr_EventUrl;

		// Token: 0x040001CA RID: 458
		private static readonly IntPtr NativeFieldInfoPtr_ProfileDict;

		// Token: 0x040001CB RID: 459
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_IUtil_IAsyncWebUtil_0;

		// Token: 0x040001CC RID: 460
		private static readonly IntPtr NativeMethodInfoPtr_Instance_Public_Static_EventQueue_IUtil_IAsyncWebUtil_0;

		// Token: 0x040001CD RID: 461
		private static readonly IntPtr NativeMethodInfoPtr_SetAdsUrl_Internal_Void_String_0;

		// Token: 0x040001CE RID: 462
		private static readonly IntPtr NativeMethodInfoPtr_SetIapUrl_Internal_Void_String_0;
	}
}
