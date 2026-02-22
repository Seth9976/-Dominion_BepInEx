using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.UIElements
{
	// Token: 0x0200004D RID: 77
	public class PointerCaptureEventBase<T> : EventBase<T> where T : PointerCaptureEventBase<T>, new()
	{
		// Token: 0x0600051E RID: 1310 RVA: 0x0001BBEC File Offset: 0x00019DEC
		// Note: this type is marked as 'beforefieldinit'.
		static PointerCaptureEventBase()
		{
			Il2CppClassPointerStore<PointerCaptureEventBase<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "PointerCaptureEventBase`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PointerCaptureEventBase<T>>.NativeClassPtr);
			PointerCaptureEventBase<T>.NativeFieldInfoPtr__relatedTarget_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PointerCaptureEventBase<T>>.NativeClassPtr, "<relatedTarget>k__BackingField");
			PointerCaptureEventBase<T>.NativeFieldInfoPtr__pointerId_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PointerCaptureEventBase<T>>.NativeClassPtr, "<pointerId>k__BackingField");
			PointerCaptureEventBase<T>.NativeMethodInfoPtr_set_relatedTarget_Private_set_Void_IEventHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerCaptureEventBase<T>>.NativeClassPtr, 100663686);
			PointerCaptureEventBase<T>.NativeMethodInfoPtr_set_pointerId_Private_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerCaptureEventBase<T>>.NativeClassPtr, 100663687);
			PointerCaptureEventBase<T>.NativeMethodInfoPtr_Init_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerCaptureEventBase<T>>.NativeClassPtr, 100663688);
			PointerCaptureEventBase<T>.NativeMethodInfoPtr_LocalInit_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerCaptureEventBase<T>>.NativeClassPtr, 100663689);
			PointerCaptureEventBase<T>.NativeMethodInfoPtr_GetPooled_Public_Static_T_IEventHandler_IEventHandler_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerCaptureEventBase<T>>.NativeClassPtr, 100663690);
			PointerCaptureEventBase<T>.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerCaptureEventBase<T>>.NativeClassPtr, 100663691);
		}

		// Token: 0x170001CC RID: 460
		// (get) Token: 0x0600052A RID: 1322 RVA: 0x000046E5 File Offset: 0x000028E5
		// (set) Token: 0x0600051F RID: 1311 RVA: 0x0001BCF8 File Offset: 0x00019EF8
		public unsafe IEventHandler relatedTarget
		{
			get
			{
				return this._relatedTarget_k__BackingField;
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerCaptureEventBase<T>.NativeMethodInfoPtr_set_relatedTarget_Private_set_Void_IEventHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170001CD RID: 461
		// (get) Token: 0x0600052B RID: 1323 RVA: 0x000046ED File Offset: 0x000028ED
		// (set) Token: 0x06000520 RID: 1312 RVA: 0x0001BD3C File Offset: 0x00019F3C
		public unsafe int pointerId
		{
			get
			{
				return this._pointerId_k__BackingField;
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerCaptureEventBase<T>.NativeMethodInfoPtr_set_pointerId_Private_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000521 RID: 1313 RVA: 0x0001BD7C File Offset: 0x00019F7C
		[CallerCount(14)]
		[CachedScanResults(RefRangeStart = 93528, RefRangeEnd = 93542, XrefRangeStart = 93527, XrefRangeEnd = 93528, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Init()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PointerCaptureEventBase<T>.NativeMethodInfoPtr_Init_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000522 RID: 1314 RVA: 0x0001BDB8 File Offset: 0x00019FB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 93542, XrefRangeEnd = 93547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe void LocalInit()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerCaptureEventBase<T>.NativeMethodInfoPtr_LocalInit_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000523 RID: 1315 RVA: 0x0001BDEC File Offset: 0x00019FEC
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 93564, RefRangeEnd = 93568, XrefRangeStart = 93547, XrefRangeEnd = 93564, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static T GetPooled(IEventHandler target, IEventHandler relatedTarget, int pointerId)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(relatedTarget);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pointerId;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerCaptureEventBase<T>.NativeMethodInfoPtr_GetPooled_Public_Static_T_IEventHandler_IEventHandler_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
		}

		// Token: 0x06000524 RID: 1316 RVA: 0x0001BE4C File Offset: 0x0001A04C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 93573, RefRangeEnd = 93575, XrefRangeStart = 93568, XrefRangeEnd = 93573, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PointerCaptureEventBase()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PointerCaptureEventBase<T>>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerCaptureEventBase<T>.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000525 RID: 1317 RVA: 0x000046A2 File Offset: 0x000028A2
		public PointerCaptureEventBase(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170001CA RID: 458
		// (get) Token: 0x06000526 RID: 1318 RVA: 0x0001BE88 File Offset: 0x0001A088
		// (set) Token: 0x06000527 RID: 1319 RVA: 0x000046AB File Offset: 0x000028AB
		public unsafe IEventHandler _relatedTarget_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PointerCaptureEventBase<T>.NativeFieldInfoPtr__relatedTarget_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEventHandler>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PointerCaptureEventBase<T>.NativeFieldInfoPtr__relatedTarget_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001CB RID: 459
		// (get) Token: 0x06000528 RID: 1320 RVA: 0x0001BEB8 File Offset: 0x0001A0B8
		// (set) Token: 0x06000529 RID: 1321 RVA: 0x000046CA File Offset: 0x000028CA
		public unsafe int _pointerId_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PointerCaptureEventBase<T>.NativeFieldInfoPtr__pointerId_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PointerCaptureEventBase<T>.NativeFieldInfoPtr__pointerId_k__BackingField)) = value;
			}
		}

		// Token: 0x040002A6 RID: 678
		private static readonly IntPtr NativeFieldInfoPtr__relatedTarget_k__BackingField;

		// Token: 0x040002A7 RID: 679
		private static readonly IntPtr NativeFieldInfoPtr__pointerId_k__BackingField;

		// Token: 0x040002A8 RID: 680
		private static readonly IntPtr NativeMethodInfoPtr_set_relatedTarget_Private_set_Void_IEventHandler_0;

		// Token: 0x040002A9 RID: 681
		private static readonly IntPtr NativeMethodInfoPtr_set_pointerId_Private_set_Void_Int32_0;

		// Token: 0x040002AA RID: 682
		private static readonly IntPtr NativeMethodInfoPtr_Init_Protected_Virtual_Void_0;

		// Token: 0x040002AB RID: 683
		private static readonly IntPtr NativeMethodInfoPtr_LocalInit_Private_Void_0;

		// Token: 0x040002AC RID: 684
		private static readonly IntPtr NativeMethodInfoPtr_GetPooled_Public_Static_T_IEventHandler_IEventHandler_Int32_0;

		// Token: 0x040002AD RID: 685
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}
