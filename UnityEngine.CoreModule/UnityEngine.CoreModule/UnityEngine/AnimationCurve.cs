using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x02000036 RID: 54
	public class AnimationCurve : Object
	{
		// Token: 0x06000174 RID: 372 RVA: 0x0001A268 File Offset: 0x00018468
		// Note: this type is marked as 'beforefieldinit'.
		static AnimationCurve()
		{
			Il2CppClassPointerStore<AnimationCurve>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "AnimationCurve");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AnimationCurve>.NativeClassPtr);
			AnimationCurve.NativeFieldInfoPtr_m_Ptr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimationCurve>.NativeClassPtr, "m_Ptr");
			AnimationCurve.NativeMethodInfoPtr_Internal_Destroy_Private_Static_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationCurve>.NativeClassPtr, 100663358);
			AnimationCurve.NativeMethodInfoPtr_Internal_Create_Private_Static_IntPtr_Il2CppStructArray_1_Keyframe_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationCurve>.NativeClassPtr, 100663359);
			AnimationCurve.NativeMethodInfoPtr_Internal_Equals_Private_Boolean_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationCurve>.NativeClassPtr, 100663360);
			AnimationCurve.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationCurve>.NativeClassPtr, 100663361);
			AnimationCurve.NativeMethodInfoPtr_Evaluate_Public_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationCurve>.NativeClassPtr, 100663362);
			AnimationCurve.NativeMethodInfoPtr_get_keys_Public_get_Il2CppStructArray_1_Keyframe_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationCurve>.NativeClassPtr, 100663363);
			AnimationCurve.NativeMethodInfoPtr_set_keys_Public_set_Void_Il2CppStructArray_1_Keyframe_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationCurve>.NativeClassPtr, 100663364);
			AnimationCurve.NativeMethodInfoPtr_SetKeys_Private_Void_Il2CppStructArray_1_Keyframe_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationCurve>.NativeClassPtr, 100663365);
			AnimationCurve.NativeMethodInfoPtr_GetKeys_Private_Il2CppStructArray_1_Keyframe_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationCurve>.NativeClassPtr, 100663366);
			AnimationCurve.NativeMethodInfoPtr_set_preWrapMode_Public_set_Void_WrapMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationCurve>.NativeClassPtr, 100663367);
			AnimationCurve.NativeMethodInfoPtr_set_postWrapMode_Public_set_Void_WrapMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationCurve>.NativeClassPtr, 100663368);
			AnimationCurve.NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Keyframe_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationCurve>.NativeClassPtr, 100663369);
			AnimationCurve.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationCurve>.NativeClassPtr, 100663370);
			AnimationCurve.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationCurve>.NativeClassPtr, 100663371);
			AnimationCurve.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_AnimationCurve_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationCurve>.NativeClassPtr, 100663372);
			AnimationCurve.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationCurve>.NativeClassPtr, 100663373);
			AnimationCurve.AddKeyDelegateField = IL2CPP.ResolveICall<AnimationCurve.AddKeyDelegate>("UnityEngine.AnimationCurve::AddKey");
			AnimationCurve.RemoveKeyDelegateField = IL2CPP.ResolveICall<AnimationCurve.RemoveKeyDelegate>("UnityEngine.AnimationCurve::RemoveKey");
			AnimationCurve.get_lengthDelegateField = IL2CPP.ResolveICall<AnimationCurve.get_lengthDelegate>("UnityEngine.AnimationCurve::get_length");
			AnimationCurve.SmoothTangentsDelegateField = IL2CPP.ResolveICall<AnimationCurve.SmoothTangentsDelegate>("UnityEngine.AnimationCurve::SmoothTangents");
			AnimationCurve.get_preWrapModeDelegateField = IL2CPP.ResolveICall<AnimationCurve.get_preWrapModeDelegate>("UnityEngine.AnimationCurve::get_preWrapMode");
			AnimationCurve.get_postWrapModeDelegateField = IL2CPP.ResolveICall<AnimationCurve.get_postWrapModeDelegate>("UnityEngine.AnimationCurve::get_postWrapMode");
			AnimationCurve.AddKey_Internal_InjectedDelegateField = IL2CPP.ResolveICall<AnimationCurve.AddKey_Internal_InjectedDelegate>("UnityEngine.AnimationCurve::AddKey_Internal_Injected");
			AnimationCurve.MoveKey_InjectedDelegateField = IL2CPP.ResolveICall<AnimationCurve.MoveKey_InjectedDelegate>("UnityEngine.AnimationCurve::MoveKey_Injected");
			AnimationCurve.GetKey_InjectedDelegateField = IL2CPP.ResolveICall<AnimationCurve.GetKey_InjectedDelegate>("UnityEngine.AnimationCurve::GetKey_Injected");
		}

		// Token: 0x06000175 RID: 373 RVA: 0x0001A474 File Offset: 0x00018674
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 59224, XrefRangeEnd = 59226, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Internal_Destroy(IntPtr ptr)
		{
			checked
			{
				IntPtr* ptr2 = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr2 = ref ptr;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimationCurve.NativeMethodInfoPtr_Internal_Destroy_Private_Static_Void_IntPtr_0, 0, (void**)ptr2, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000176 RID: 374 RVA: 0x0001A4A8 File Offset: 0x000186A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 59226, XrefRangeEnd = 59228, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr Internal_Create(Il2CppStructArray<Keyframe> keys)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(keys);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimationCurve.NativeMethodInfoPtr_Internal_Create_Private_Static_IntPtr_Il2CppStructArray_1_Keyframe_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000177 RID: 375 RVA: 0x0001A4EC File Offset: 0x000186EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 59228, XrefRangeEnd = 59230, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Internal_Equals(IntPtr other)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref other;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimationCurve.NativeMethodInfoPtr_Internal_Equals_Private_Boolean_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000178 RID: 376 RVA: 0x0001A538 File Offset: 0x00018738
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 59230, XrefRangeEnd = 59235, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe void Finalize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AnimationCurve.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000179 RID: 377 RVA: 0x0001A574 File Offset: 0x00018774
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 59237, RefRangeEnd = 59242, XrefRangeStart = 59235, XrefRangeEnd = 59237, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float Evaluate(float time)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref time;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimationCurve.NativeMethodInfoPtr_Evaluate_Public_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000042 RID: 66
		// (get) Token: 0x0600017A RID: 378 RVA: 0x0001A5C0 File Offset: 0x000187C0
		// (set) Token: 0x0600017B RID: 379 RVA: 0x0001A600 File Offset: 0x00018800
		public unsafe Il2CppStructArray<Keyframe> keys
		{
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 59244, RefRangeEnd = 59250, XrefRangeStart = 59242, XrefRangeEnd = 59244, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimationCurve.NativeMethodInfoPtr_get_keys_Public_get_Il2CppStructArray_1_Keyframe_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Keyframe>>(intPtr3) : null;
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 59252, RefRangeEnd = 59254, XrefRangeStart = 59250, XrefRangeEnd = 59252, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimationCurve.NativeMethodInfoPtr_set_keys_Public_set_Void_Il2CppStructArray_1_Keyframe_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x0600017C RID: 380 RVA: 0x0001A644 File Offset: 0x00018844
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 59252, RefRangeEnd = 59254, XrefRangeStart = 59252, XrefRangeEnd = 59254, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetKeys(Il2CppStructArray<Keyframe> keys)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(keys);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimationCurve.NativeMethodInfoPtr_SetKeys_Private_Void_Il2CppStructArray_1_Keyframe_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600017D RID: 381 RVA: 0x0001A688 File Offset: 0x00018888
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 59244, RefRangeEnd = 59250, XrefRangeStart = 59244, XrefRangeEnd = 59250, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppStructArray<Keyframe> GetKeys()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimationCurve.NativeMethodInfoPtr_GetKeys_Private_Il2CppStructArray_1_Keyframe_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Keyframe>>(intPtr3) : null;
		}

		// Token: 0x17000043 RID: 67
		// (get) Token: 0x06000195 RID: 405 RVA: 0x0000303F File Offset: 0x0000123F
		// (set) Token: 0x0600017E RID: 382 RVA: 0x0001A6C8 File Offset: 0x000188C8
		public unsafe WrapMode preWrapMode
		{
			get
			{
				return AnimationCurve.get_preWrapModeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 59256, RefRangeEnd = 59258, XrefRangeStart = 59254, XrefRangeEnd = 59256, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimationCurve.NativeMethodInfoPtr_set_preWrapMode_Public_set_Void_WrapMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000044 RID: 68
		// (get) Token: 0x06000196 RID: 406 RVA: 0x00003051 File Offset: 0x00001251
		// (set) Token: 0x0600017F RID: 383 RVA: 0x0001A708 File Offset: 0x00018908
		public unsafe WrapMode postWrapMode
		{
			get
			{
				return AnimationCurve.get_postWrapModeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 59260, RefRangeEnd = 59262, XrefRangeStart = 59258, XrefRangeEnd = 59260, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimationCurve.NativeMethodInfoPtr_set_postWrapMode_Public_set_Void_WrapMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000180 RID: 384 RVA: 0x0001A748 File Offset: 0x00018948
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 59265, RefRangeEnd = 59267, XrefRangeStart = 59262, XrefRangeEnd = 59265, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AnimationCurve([Optional] Il2CppStructArray<Keyframe> keys)
		{
			if (keys == null)
			{
				keys = new Il2CppStructArray<Keyframe>(0L);
			}
			this..ctor(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AnimationCurve>.NativeClassPtr));
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(keys);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimationCurve.NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Keyframe_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000181 RID: 385 RVA: 0x0001A7A0 File Offset: 0x000189A0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 59270, RefRangeEnd = 59272, XrefRangeStart = 59267, XrefRangeEnd = 59270, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AnimationCurve()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AnimationCurve>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimationCurve.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000182 RID: 386 RVA: 0x0001A7DC File Offset: 0x000189DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 59272, XrefRangeEnd = 59282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object o)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(o);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AnimationCurve.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000183 RID: 387 RVA: 0x0001A834 File Offset: 0x00018A34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 59282, XrefRangeEnd = 59288, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool Equals(AnimationCurve other)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimationCurve.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_AnimationCurve_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000184 RID: 388 RVA: 0x0001A884 File Offset: 0x00018A84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 59288, XrefRangeEnd = 59289, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AnimationCurve.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000185 RID: 389 RVA: 0x00002F91 File Offset: 0x00001191
		public AnimationCurve(params Keyframe[] keys)
			: this(new Il2CppStructArray<Keyframe>(keys))
		{
		}

		// Token: 0x06000186 RID: 390 RVA: 0x00002F9F File Offset: 0x0000119F
		public AnimationCurve(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000041 RID: 65
		// (get) Token: 0x06000187 RID: 391 RVA: 0x0001A8CC File Offset: 0x00018ACC
		// (set) Token: 0x06000188 RID: 392 RVA: 0x00002FA8 File Offset: 0x000011A8
		public unsafe IntPtr m_Ptr
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimationCurve.NativeFieldInfoPtr_m_Ptr);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimationCurve.NativeFieldInfoPtr_m_Ptr)) = value;
			}
		}

		// Token: 0x06000189 RID: 393 RVA: 0x00002FC3 File Offset: 0x000011C3
		public int AddKey(float time, float value)
		{
			return AnimationCurve.AddKeyDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), time, value);
		}

		// Token: 0x0600018A RID: 394 RVA: 0x0001A8F4 File Offset: 0x00018AF4
		public int AddKey(Keyframe key)
		{
			return this.AddKey_Internal(key);
		}

		// Token: 0x0600018B RID: 395 RVA: 0x00002FD7 File Offset: 0x000011D7
		public int AddKey_Internal(Keyframe key)
		{
			return this.AddKey_Internal_Injected(ref key);
		}

		// Token: 0x0600018C RID: 396 RVA: 0x00002FE1 File Offset: 0x000011E1
		public int MoveKey(int index, Keyframe key)
		{
			return this.MoveKey_Injected(index, ref key);
		}

		// Token: 0x0600018D RID: 397 RVA: 0x00002FEC File Offset: 0x000011EC
		public void RemoveKey(int index)
		{
			AnimationCurve.RemoveKeyDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), index);
		}

		// Token: 0x17000045 RID: 69
		public Keyframe this[int index]
		{
			get
			{
				return this.GetKey(index);
			}
		}

		// Token: 0x17000046 RID: 70
		// (get) Token: 0x0600018F RID: 399 RVA: 0x00002FFF File Offset: 0x000011FF
		public int length
		{
			get
			{
				return AnimationCurve.get_lengthDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x06000190 RID: 400 RVA: 0x0001A92C File Offset: 0x00018B2C
		public Keyframe GetKey(int index)
		{
			Keyframe keyframe;
			this.GetKey_Injected(index, out keyframe);
			return keyframe;
		}

		// Token: 0x06000191 RID: 401 RVA: 0x00003011 File Offset: 0x00001211
		public void SmoothTangents(int index, float weight)
		{
			AnimationCurve.SmoothTangentsDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), index, weight);
		}

		// Token: 0x06000192 RID: 402 RVA: 0x0001A944 File Offset: 0x00018B44
		public static AnimationCurve Constant(float timeStart, float timeEnd, float value)
		{
			return AnimationCurve.Linear(timeStart, value, timeEnd, value);
		}

		// Token: 0x06000193 RID: 403 RVA: 0x00003025 File Offset: 0x00001225
		public static AnimationCurve Linear(float timeStart, float valueStart, float timeEnd, float valueEnd)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000194 RID: 404 RVA: 0x00003032 File Offset: 0x00001232
		public static AnimationCurve EaseInOut(float timeStart, float valueStart, float timeEnd, float valueEnd)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000197 RID: 407 RVA: 0x00003063 File Offset: 0x00001263
		public int AddKey_Internal_Injected(ref Keyframe key)
		{
			return AnimationCurve.AddKey_Internal_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref key);
		}

		// Token: 0x06000198 RID: 408 RVA: 0x00003076 File Offset: 0x00001276
		public int MoveKey_Injected(int index, ref Keyframe key)
		{
			return AnimationCurve.MoveKey_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), index, ref key);
		}

		// Token: 0x06000199 RID: 409 RVA: 0x0000308A File Offset: 0x0000128A
		public void GetKey_Injected(int index, out Keyframe ret)
		{
			AnimationCurve.GetKey_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), index, out ret);
		}

		// Token: 0x04000118 RID: 280
		private static readonly IntPtr NativeFieldInfoPtr_m_Ptr;

		// Token: 0x04000119 RID: 281
		private static readonly IntPtr NativeMethodInfoPtr_Internal_Destroy_Private_Static_Void_IntPtr_0;

		// Token: 0x0400011A RID: 282
		private static readonly IntPtr NativeMethodInfoPtr_Internal_Create_Private_Static_IntPtr_Il2CppStructArray_1_Keyframe_0;

		// Token: 0x0400011B RID: 283
		private static readonly IntPtr NativeMethodInfoPtr_Internal_Equals_Private_Boolean_IntPtr_0;

		// Token: 0x0400011C RID: 284
		private static readonly IntPtr NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0;

		// Token: 0x0400011D RID: 285
		private static readonly IntPtr NativeMethodInfoPtr_Evaluate_Public_Single_Single_0;

		// Token: 0x0400011E RID: 286
		private static readonly IntPtr NativeMethodInfoPtr_get_keys_Public_get_Il2CppStructArray_1_Keyframe_0;

		// Token: 0x0400011F RID: 287
		private static readonly IntPtr NativeMethodInfoPtr_set_keys_Public_set_Void_Il2CppStructArray_1_Keyframe_0;

		// Token: 0x04000120 RID: 288
		private static readonly IntPtr NativeMethodInfoPtr_SetKeys_Private_Void_Il2CppStructArray_1_Keyframe_0;

		// Token: 0x04000121 RID: 289
		private static readonly IntPtr NativeMethodInfoPtr_GetKeys_Private_Il2CppStructArray_1_Keyframe_0;

		// Token: 0x04000122 RID: 290
		private static readonly IntPtr NativeMethodInfoPtr_set_preWrapMode_Public_set_Void_WrapMode_0;

		// Token: 0x04000123 RID: 291
		private static readonly IntPtr NativeMethodInfoPtr_set_postWrapMode_Public_set_Void_WrapMode_0;

		// Token: 0x04000124 RID: 292
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Keyframe_0;

		// Token: 0x04000125 RID: 293
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000126 RID: 294
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x04000127 RID: 295
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_AnimationCurve_0;

		// Token: 0x04000128 RID: 296
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x04000129 RID: 297
		private static readonly AnimationCurve.AddKeyDelegate AddKeyDelegateField;

		// Token: 0x0400012A RID: 298
		private static readonly AnimationCurve.RemoveKeyDelegate RemoveKeyDelegateField;

		// Token: 0x0400012B RID: 299
		private static readonly AnimationCurve.get_lengthDelegate get_lengthDelegateField;

		// Token: 0x0400012C RID: 300
		private static readonly AnimationCurve.SmoothTangentsDelegate SmoothTangentsDelegateField;

		// Token: 0x0400012D RID: 301
		private static readonly AnimationCurve.get_preWrapModeDelegate get_preWrapModeDelegateField;

		// Token: 0x0400012E RID: 302
		private static readonly AnimationCurve.get_postWrapModeDelegate get_postWrapModeDelegateField;

		// Token: 0x0400012F RID: 303
		private static readonly AnimationCurve.AddKey_Internal_InjectedDelegate AddKey_Internal_InjectedDelegateField;

		// Token: 0x04000130 RID: 304
		private static readonly AnimationCurve.MoveKey_InjectedDelegate MoveKey_InjectedDelegateField;

		// Token: 0x04000131 RID: 305
		private static readonly AnimationCurve.GetKey_InjectedDelegate GetKey_InjectedDelegateField;

		// Token: 0x02000317 RID: 791
		// (Invoke) Token: 0x060023EA RID: 9194
		private delegate int AddKeyDelegate(IntPtr @this, float time, float value);

		// Token: 0x02000318 RID: 792
		// (Invoke) Token: 0x060023EC RID: 9196
		private delegate void RemoveKeyDelegate(IntPtr @this, int index);

		// Token: 0x02000319 RID: 793
		// (Invoke) Token: 0x060023EE RID: 9198
		private delegate int get_lengthDelegate(IntPtr @this);

		// Token: 0x0200031A RID: 794
		// (Invoke) Token: 0x060023F0 RID: 9200
		private delegate void SmoothTangentsDelegate(IntPtr @this, int index, float weight);

		// Token: 0x0200031B RID: 795
		// (Invoke) Token: 0x060023F2 RID: 9202
		private delegate WrapMode get_preWrapModeDelegate(IntPtr @this);

		// Token: 0x0200031C RID: 796
		// (Invoke) Token: 0x060023F4 RID: 9204
		private delegate WrapMode get_postWrapModeDelegate(IntPtr @this);

		// Token: 0x0200031D RID: 797
		// (Invoke) Token: 0x060023F6 RID: 9206
		private delegate int AddKey_Internal_InjectedDelegate(IntPtr @this, IntPtr key);

		// Token: 0x0200031E RID: 798
		// (Invoke) Token: 0x060023F8 RID: 9208
		private delegate int MoveKey_InjectedDelegate(IntPtr @this, int index, IntPtr key);

		// Token: 0x0200031F RID: 799
		// (Invoke) Token: 0x060023FA RID: 9210
		private delegate void GetKey_InjectedDelegate(IntPtr @this, int index, [Out] IntPtr ret);
	}
}
