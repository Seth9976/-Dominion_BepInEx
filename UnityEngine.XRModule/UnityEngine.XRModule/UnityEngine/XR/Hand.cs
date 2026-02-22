using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine.XR
{
	// Token: 0x0200000C RID: 12
	[StructLayout(2)]
	public struct Hand
	{
		// Token: 0x06000063 RID: 99 RVA: 0x00003B78 File Offset: 0x00001D78
		// Note: this type is marked as 'beforefieldinit'.
		static Hand()
		{
			Il2CppClassPointerStore<Hand>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.XRModule.dll", "UnityEngine.XR", "Hand");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Hand>.NativeClassPtr);
			Hand.NativeFieldInfoPtr_m_DeviceId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Hand>.NativeClassPtr, "m_DeviceId");
			Hand.NativeFieldInfoPtr_m_FeatureIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Hand>.NativeClassPtr, "m_FeatureIndex");
			Hand.NativeMethodInfoPtr_get_deviceId_Internal_get_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hand>.NativeClassPtr, 100663314);
			Hand.NativeMethodInfoPtr_get_featureIndex_Internal_get_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hand>.NativeClassPtr, 100663315);
			Hand.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hand>.NativeClassPtr, 100663316);
			Hand.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_Hand_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hand>.NativeClassPtr, 100663317);
			Hand.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hand>.NativeClassPtr, 100663318);
			Hand.Hand_TryGetRootBone_InjectedDelegateField = IL2CPP.ResolveICall<Hand.Hand_TryGetRootBone_InjectedDelegate>("UnityEngine.XR.Hand::Hand_TryGetRootBone_Injected");
			Hand.Hand_TryGetFingerBonesAsList_InjectedDelegateField = IL2CPP.ResolveICall<Hand.Hand_TryGetFingerBonesAsList_InjectedDelegate>("UnityEngine.XR.Hand::Hand_TryGetFingerBonesAsList_Injected");
		}

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x06000064 RID: 100 RVA: 0x00003C54 File Offset: 0x00001E54
		public unsafe ulong deviceId
		{
			[CallerCount(19)]
			[CachedScanResults(RefRangeStart = 59099, RefRangeEnd = 59118, XrefRangeStart = 59099, XrefRangeEnd = 59118, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Hand.NativeMethodInfoPtr_get_deviceId_Internal_get_UInt64_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x06000065 RID: 101 RVA: 0x00003C84 File Offset: 0x00001E84
		public unsafe uint featureIndex
		{
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 62297, RefRangeEnd = 62303, XrefRangeStart = 62297, XrefRangeEnd = 62303, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Hand.NativeMethodInfoPtr_get_featureIndex_Internal_get_UInt32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000066 RID: 102 RVA: 0x00003CB4 File Offset: 0x00001EB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 158296, XrefRangeEnd = 158299, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object obj)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Hand.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000067 RID: 103 RVA: 0x00003CF8 File Offset: 0x00001EF8
		[CallerCount(0)]
		public unsafe bool Equals(Hand other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref other;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Hand.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_Hand_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000068 RID: 104 RVA: 0x00003D38 File Offset: 0x00001F38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 158299, XrefRangeEnd = 158301, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Hand.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000069 RID: 105 RVA: 0x0000232C File Offset: 0x0000052C
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Hand>.NativeClassPtr, ref this));
		}

		// Token: 0x0600006A RID: 106 RVA: 0x00003D68 File Offset: 0x00001F68
		public bool TryGetRootBone(out Bone boneOut)
		{
			return Hand.Hand_TryGetRootBone(this, out boneOut);
		}

		// Token: 0x0600006B RID: 107 RVA: 0x0000233E File Offset: 0x0000053E
		public static bool Hand_TryGetRootBone(Hand hand, out Bone boneOut)
		{
			return Hand.Hand_TryGetRootBone_Injected(ref hand, out boneOut);
		}

		// Token: 0x0600006C RID: 108 RVA: 0x00003D88 File Offset: 0x00001F88
		public bool TryGetFingerBones(HandFinger finger, List<Bone> bonesOut)
		{
			bool flag = bonesOut == null;
			if (flag)
			{
				throw new ArgumentNullException("bonesOut");
			}
			return Hand.Hand_TryGetFingerBonesAsList(this, finger, bonesOut);
		}

		// Token: 0x0600006D RID: 109 RVA: 0x00002348 File Offset: 0x00000548
		public static bool Hand_TryGetFingerBonesAsList(Hand hand, HandFinger finger, List<Bone> bonesOut)
		{
			return Hand.Hand_TryGetFingerBonesAsList_Injected(ref hand, finger, bonesOut);
		}

		// Token: 0x0600006E RID: 110 RVA: 0x00003DBC File Offset: 0x00001FBC
		public static bool operator ==(Hand a, Hand b)
		{
			return a.Equals(b);
		}

		// Token: 0x0600006F RID: 111 RVA: 0x00003DD8 File Offset: 0x00001FD8
		public static bool operator !=(Hand a, Hand b)
		{
			return !(a == b);
		}

		// Token: 0x06000070 RID: 112 RVA: 0x00002353 File Offset: 0x00000553
		public static bool Hand_TryGetRootBone_Injected(ref Hand hand, out Bone boneOut)
		{
			return Hand.Hand_TryGetRootBone_InjectedDelegateField(ref hand, out boneOut);
		}

		// Token: 0x06000071 RID: 113 RVA: 0x00002361 File Offset: 0x00000561
		public static bool Hand_TryGetFingerBonesAsList_Injected(ref Hand hand, HandFinger finger, List<Bone> bonesOut)
		{
			return Hand.Hand_TryGetFingerBonesAsList_InjectedDelegateField(ref hand, finger, IL2CPP.Il2CppObjectBaseToPtr(bonesOut));
		}

		// Token: 0x0400005A RID: 90
		private static readonly IntPtr NativeFieldInfoPtr_m_DeviceId;

		// Token: 0x0400005B RID: 91
		private static readonly IntPtr NativeFieldInfoPtr_m_FeatureIndex;

		// Token: 0x0400005C RID: 92
		private static readonly IntPtr NativeMethodInfoPtr_get_deviceId_Internal_get_UInt64_0;

		// Token: 0x0400005D RID: 93
		private static readonly IntPtr NativeMethodInfoPtr_get_featureIndex_Internal_get_UInt32_0;

		// Token: 0x0400005E RID: 94
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x0400005F RID: 95
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_Hand_0;

		// Token: 0x04000060 RID: 96
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x04000061 RID: 97
		[FieldOffset(0)]
		public ulong m_DeviceId;

		// Token: 0x04000062 RID: 98
		[FieldOffset(8)]
		public uint m_FeatureIndex;

		// Token: 0x04000063 RID: 99
		private static readonly Hand.Hand_TryGetRootBone_InjectedDelegate Hand_TryGetRootBone_InjectedDelegateField;

		// Token: 0x04000064 RID: 100
		private static readonly Hand.Hand_TryGetFingerBonesAsList_InjectedDelegate Hand_TryGetFingerBonesAsList_InjectedDelegateField;

		// Token: 0x02000030 RID: 48
		// (Invoke) Token: 0x0600016B RID: 363
		private delegate bool Hand_TryGetRootBone_InjectedDelegate(IntPtr hand, [Out] IntPtr boneOut);

		// Token: 0x02000031 RID: 49
		// (Invoke) Token: 0x0600016D RID: 365
		private delegate bool Hand_TryGetFingerBonesAsList_InjectedDelegate(IntPtr hand, HandFinger finger, IntPtr bonesOut);
	}
}
