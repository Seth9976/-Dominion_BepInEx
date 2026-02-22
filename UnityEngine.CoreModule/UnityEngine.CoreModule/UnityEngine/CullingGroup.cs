using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x0200003B RID: 59
	public class CullingGroup : Object
	{
		// Token: 0x06000321 RID: 801 RVA: 0x0001D9F0 File Offset: 0x0001BBF0
		// Note: this type is marked as 'beforefieldinit'.
		static CullingGroup()
		{
			Il2CppClassPointerStore<CullingGroup>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "CullingGroup");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CullingGroup>.NativeClassPtr);
			CullingGroup.NativeFieldInfoPtr_m_Ptr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CullingGroup>.NativeClassPtr, "m_Ptr");
			CullingGroup.NativeFieldInfoPtr_m_OnStateChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CullingGroup>.NativeClassPtr, "m_OnStateChanged");
			CullingGroup.NativeMethodInfoPtr_SendEvents_Private_Static_Void_CullingGroup_IntPtr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CullingGroup>.NativeClassPtr, 100663445);
			CullingGroup.DisposeInternalDelegateField = IL2CPP.ResolveICall<CullingGroup.DisposeInternalDelegate>("UnityEngine.CullingGroup::DisposeInternal");
			CullingGroup.get_enabledDelegateField = IL2CPP.ResolveICall<CullingGroup.get_enabledDelegate>("UnityEngine.CullingGroup::get_enabled");
			CullingGroup.set_enabledDelegateField = IL2CPP.ResolveICall<CullingGroup.set_enabledDelegate>("UnityEngine.CullingGroup::set_enabled");
			CullingGroup.get_targetCameraDelegateField = IL2CPP.ResolveICall<CullingGroup.get_targetCameraDelegate>("UnityEngine.CullingGroup::get_targetCamera");
			CullingGroup.set_targetCameraDelegateField = IL2CPP.ResolveICall<CullingGroup.set_targetCameraDelegate>("UnityEngine.CullingGroup::set_targetCamera");
			CullingGroup.SetBoundingSphereCountDelegateField = IL2CPP.ResolveICall<CullingGroup.SetBoundingSphereCountDelegate>("UnityEngine.CullingGroup::SetBoundingSphereCount");
			CullingGroup.EraseSwapBackDelegateField = IL2CPP.ResolveICall<CullingGroup.EraseSwapBackDelegate>("UnityEngine.CullingGroup::EraseSwapBack");
			CullingGroup.QueryIndicesDelegateField = IL2CPP.ResolveICall<CullingGroup.QueryIndicesDelegate>("UnityEngine.CullingGroup::QueryIndices");
			CullingGroup.IsVisibleDelegateField = IL2CPP.ResolveICall<CullingGroup.IsVisibleDelegate>("UnityEngine.CullingGroup::IsVisible");
			CullingGroup.GetDistanceDelegateField = IL2CPP.ResolveICall<CullingGroup.GetDistanceDelegate>("UnityEngine.CullingGroup::GetDistance");
			CullingGroup.SetBoundingDistancesDelegateField = IL2CPP.ResolveICall<CullingGroup.SetBoundingDistancesDelegate>("UnityEngine.CullingGroup::SetBoundingDistances");
			CullingGroup.SetDistanceReferencePoint_InternalTransformDelegateField = IL2CPP.ResolveICall<CullingGroup.SetDistanceReferencePoint_InternalTransformDelegate>("UnityEngine.CullingGroup::SetDistanceReferencePoint_InternalTransform");
			CullingGroup.InitDelegateField = IL2CPP.ResolveICall<CullingGroup.InitDelegate>("UnityEngine.CullingGroup::Init");
			CullingGroup.FinalizerFailureDelegateField = IL2CPP.ResolveICall<CullingGroup.FinalizerFailureDelegate>("UnityEngine.CullingGroup::FinalizerFailure");
			CullingGroup.SetDistanceReferencePoint_InternalVector3_InjectedDelegateField = IL2CPP.ResolveICall<CullingGroup.SetDistanceReferencePoint_InternalVector3_InjectedDelegate>("UnityEngine.CullingGroup::SetDistanceReferencePoint_InternalVector3_Injected");
		}

		// Token: 0x06000322 RID: 802 RVA: 0x0001DB40 File Offset: 0x0001BD40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 60136, XrefRangeEnd = 60137, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SendEvents(CullingGroup cullingGroup, IntPtr eventsPtr, int count)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cullingGroup);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref eventsPtr;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CullingGroup.NativeMethodInfoPtr_SendEvents_Private_Static_Void_CullingGroup_IntPtr_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000323 RID: 803 RVA: 0x00003F91 File Offset: 0x00002191
		public CullingGroup(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000C7 RID: 199
		// (get) Token: 0x06000324 RID: 804 RVA: 0x0001DB94 File Offset: 0x0001BD94
		// (set) Token: 0x06000325 RID: 805 RVA: 0x00003F9A File Offset: 0x0000219A
		public unsafe IntPtr m_Ptr
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CullingGroup.NativeFieldInfoPtr_m_Ptr);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CullingGroup.NativeFieldInfoPtr_m_Ptr)) = value;
			}
		}

		// Token: 0x170000C8 RID: 200
		// (get) Token: 0x06000326 RID: 806 RVA: 0x0001DBBC File Offset: 0x0001BDBC
		// (set) Token: 0x06000327 RID: 807 RVA: 0x00003FB5 File Offset: 0x000021B5
		public unsafe CullingGroup.StateChanged m_OnStateChanged
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CullingGroup.NativeFieldInfoPtr_m_OnStateChanged);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CullingGroup.StateChanged>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CullingGroup.NativeFieldInfoPtr_m_OnStateChanged), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x06000328 RID: 808 RVA: 0x0001DBEC File Offset: 0x0001BDEC
		public override void Finalize()
		{
			try
			{
				bool flag = this.m_Ptr != IntPtr.Zero;
				if (flag)
				{
					this.FinalizerFailure();
				}
			}
			finally
			{
				base.Finalize();
			}
		}

		// Token: 0x06000329 RID: 809 RVA: 0x00003FD4 File Offset: 0x000021D4
		public void DisposeInternal()
		{
			CullingGroup.DisposeInternalDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x0600032A RID: 810 RVA: 0x00003FE6 File Offset: 0x000021E6
		public void Dispose()
		{
			this.DisposeInternal();
			this.m_Ptr = IntPtr.Zero;
		}

		// Token: 0x170000C9 RID: 201
		// (get) Token: 0x0600032B RID: 811 RVA: 0x0001DC34 File Offset: 0x0001BE34
		// (set) Token: 0x0600032C RID: 812 RVA: 0x00003FFB File Offset: 0x000021FB
		public CullingGroup.StateChanged onStateChanged
		{
			get
			{
				return this.m_OnStateChanged;
			}
			set
			{
				this.m_OnStateChanged = value;
			}
		}

		// Token: 0x170000CA RID: 202
		// (get) Token: 0x0600032D RID: 813 RVA: 0x00004005 File Offset: 0x00002205
		// (set) Token: 0x0600032E RID: 814 RVA: 0x00004017 File Offset: 0x00002217
		public bool enabled
		{
			get
			{
				return CullingGroup.get_enabledDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				CullingGroup.set_enabledDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170000CB RID: 203
		// (get) Token: 0x0600032F RID: 815 RVA: 0x0001DC4C File Offset: 0x0001BE4C
		// (set) Token: 0x06000330 RID: 816 RVA: 0x0000402A File Offset: 0x0000222A
		public Camera targetCamera
		{
			get
			{
				IntPtr intPtr = CullingGroup.get_targetCameraDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Camera>(intPtr2) : null;
			}
			set
			{
				CullingGroup.set_targetCameraDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x06000331 RID: 817 RVA: 0x00004042 File Offset: 0x00002242
		public void SetBoundingSphereCount(int count)
		{
			CullingGroup.SetBoundingSphereCountDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), count);
		}

		// Token: 0x06000332 RID: 818 RVA: 0x00004055 File Offset: 0x00002255
		public void EraseSwapBack(int index)
		{
			CullingGroup.EraseSwapBackDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), index);
		}

		// Token: 0x06000333 RID: 819 RVA: 0x00004068 File Offset: 0x00002268
		public static void EraseSwapBack<T>(int index, Il2CppArrayBase<T> myArray, ref int size)
		{
			size--;
			myArray[index] = myArray[size];
		}

		// Token: 0x06000334 RID: 820 RVA: 0x0001DC78 File Offset: 0x0001BE78
		public int QueryIndices(bool visible, Il2CppStructArray<int> result, int firstIndex)
		{
			return this.QueryIndices(visible, -1, CullingQueryOptions.IgnoreDistance, result, firstIndex);
		}

		// Token: 0x06000335 RID: 821 RVA: 0x0001DC98 File Offset: 0x0001BE98
		public int QueryIndices(int distanceIndex, Il2CppStructArray<int> result, int firstIndex)
		{
			return this.QueryIndices(false, distanceIndex, CullingQueryOptions.IgnoreVisibility, result, firstIndex);
		}

		// Token: 0x06000336 RID: 822 RVA: 0x0001DCB8 File Offset: 0x0001BEB8
		public int QueryIndices(bool visible, int distanceIndex, Il2CppStructArray<int> result, int firstIndex)
		{
			return this.QueryIndices(visible, distanceIndex, CullingQueryOptions.Normal, result, firstIndex);
		}

		// Token: 0x06000337 RID: 823 RVA: 0x00004080 File Offset: 0x00002280
		public int QueryIndices(bool visible, int distanceIndex, CullingQueryOptions options, Il2CppStructArray<int> result, int firstIndex)
		{
			return CullingGroup.QueryIndicesDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), visible, distanceIndex, options, IL2CPP.Il2CppObjectBaseToPtr(result), firstIndex);
		}

		// Token: 0x06000338 RID: 824 RVA: 0x0000409E File Offset: 0x0000229E
		public bool IsVisible(int index)
		{
			return CullingGroup.IsVisibleDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), index);
		}

		// Token: 0x06000339 RID: 825 RVA: 0x000040B1 File Offset: 0x000022B1
		public int GetDistance(int index)
		{
			return CullingGroup.GetDistanceDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), index);
		}

		// Token: 0x0600033A RID: 826 RVA: 0x000040C4 File Offset: 0x000022C4
		public void SetBoundingDistances(Il2CppStructArray<float> distances)
		{
			CullingGroup.SetBoundingDistancesDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(distances));
		}

		// Token: 0x0600033B RID: 827 RVA: 0x000040DC File Offset: 0x000022DC
		public void SetDistanceReferencePoint_InternalVector3(Vector3 point)
		{
			this.SetDistanceReferencePoint_InternalVector3_Injected(ref point);
		}

		// Token: 0x0600033C RID: 828 RVA: 0x000040E6 File Offset: 0x000022E6
		public void SetDistanceReferencePoint_InternalTransform(Transform transform)
		{
			CullingGroup.SetDistanceReferencePoint_InternalTransformDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(transform));
		}

		// Token: 0x0600033D RID: 829 RVA: 0x000040FE File Offset: 0x000022FE
		public void SetDistanceReferencePoint(Vector3 point)
		{
			this.SetDistanceReferencePoint_InternalVector3(point);
		}

		// Token: 0x0600033E RID: 830 RVA: 0x00004109 File Offset: 0x00002309
		public void SetDistanceReferencePoint(Transform transform)
		{
			this.SetDistanceReferencePoint_InternalTransform(transform);
		}

		// Token: 0x0600033F RID: 831 RVA: 0x00004114 File Offset: 0x00002314
		public static IntPtr Init(Object scripting)
		{
			return CullingGroup.InitDelegateField(IL2CPP.Il2CppObjectBaseToPtr(scripting));
		}

		// Token: 0x06000340 RID: 832 RVA: 0x00004126 File Offset: 0x00002326
		public void FinalizerFailure()
		{
			CullingGroup.FinalizerFailureDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x06000341 RID: 833 RVA: 0x00004138 File Offset: 0x00002338
		public void SetDistanceReferencePoint_InternalVector3_Injected(ref Vector3 point)
		{
			CullingGroup.SetDistanceReferencePoint_InternalVector3_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref point);
		}

		// Token: 0x0400023C RID: 572
		private static readonly IntPtr NativeFieldInfoPtr_m_Ptr;

		// Token: 0x0400023D RID: 573
		private static readonly IntPtr NativeFieldInfoPtr_m_OnStateChanged;

		// Token: 0x0400023E RID: 574
		private static readonly IntPtr NativeMethodInfoPtr_SendEvents_Private_Static_Void_CullingGroup_IntPtr_Int32_0;

		// Token: 0x0400023F RID: 575
		private static readonly CullingGroup.DisposeInternalDelegate DisposeInternalDelegateField;

		// Token: 0x04000240 RID: 576
		private static readonly CullingGroup.get_enabledDelegate get_enabledDelegateField;

		// Token: 0x04000241 RID: 577
		private static readonly CullingGroup.set_enabledDelegate set_enabledDelegateField;

		// Token: 0x04000242 RID: 578
		private static readonly CullingGroup.get_targetCameraDelegate get_targetCameraDelegateField;

		// Token: 0x04000243 RID: 579
		private static readonly CullingGroup.set_targetCameraDelegate set_targetCameraDelegateField;

		// Token: 0x04000244 RID: 580
		private static readonly CullingGroup.SetBoundingSphereCountDelegate SetBoundingSphereCountDelegateField;

		// Token: 0x04000245 RID: 581
		private static readonly CullingGroup.EraseSwapBackDelegate EraseSwapBackDelegateField;

		// Token: 0x04000246 RID: 582
		private static readonly CullingGroup.QueryIndicesDelegate QueryIndicesDelegateField;

		// Token: 0x04000247 RID: 583
		private static readonly CullingGroup.IsVisibleDelegate IsVisibleDelegateField;

		// Token: 0x04000248 RID: 584
		private static readonly CullingGroup.GetDistanceDelegate GetDistanceDelegateField;

		// Token: 0x04000249 RID: 585
		private static readonly CullingGroup.SetBoundingDistancesDelegate SetBoundingDistancesDelegateField;

		// Token: 0x0400024A RID: 586
		private static readonly CullingGroup.SetDistanceReferencePoint_InternalTransformDelegate SetDistanceReferencePoint_InternalTransformDelegateField;

		// Token: 0x0400024B RID: 587
		private static readonly CullingGroup.InitDelegate InitDelegateField;

		// Token: 0x0400024C RID: 588
		private static readonly CullingGroup.FinalizerFailureDelegate FinalizerFailureDelegateField;

		// Token: 0x0400024D RID: 589
		private static readonly CullingGroup.SetDistanceReferencePoint_InternalVector3_InjectedDelegate SetDistanceReferencePoint_InternalVector3_InjectedDelegateField;

		// Token: 0x020003E1 RID: 993
		public sealed class StateChanged : MulticastDelegate
		{
			// Token: 0x06002585 RID: 9605 RVA: 0x000151FD File Offset: 0x000133FD
			// Note: this type is marked as 'beforefieldinit'.
			static StateChanged()
			{
				Il2CppClassPointerStore<CullingGroup.StateChanged>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CullingGroup>.NativeClassPtr, "StateChanged");
				CullingGroup.StateChanged.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CullingGroup.StateChanged>.NativeClassPtr, 100663446);
				CullingGroup.StateChanged.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_CullingGroupEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CullingGroup.StateChanged>.NativeClassPtr, 100663447);
			}

			// Token: 0x06002586 RID: 9606 RVA: 0x0006B76C File Offset: 0x0006996C
			[CallerCount(1135)]
			[CachedScanResults(RefRangeStart = 9068, RefRangeEnd = 10203, XrefRangeStart = 9068, XrefRangeEnd = 10203, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe StateChanged(Object @object, IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CullingGroup.StateChanged>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CullingGroup.StateChanged.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002587 RID: 9607 RVA: 0x0006B7C8 File Offset: 0x000699C8
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 60135, RefRangeEnd = 60136, XrefRangeStart = 60130, XrefRangeEnd = 60135, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Invoke(CullingGroupEvent sphere)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref sphere;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CullingGroup.StateChanged.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_CullingGroupEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002588 RID: 9608 RVA: 0x0001523B File Offset: 0x0001343B
			public StateChanged(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06002589 RID: 9609 RVA: 0x00015244 File Offset: 0x00013444
			public static implicit operator CullingGroup.StateChanged(Action<CullingGroupEvent> A_0)
			{
				return DelegateSupport.ConvertDelegate<CullingGroup.StateChanged>(A_0);
			}

			// Token: 0x0600258A RID: 9610 RVA: 0x0001524C File Offset: 0x0001344C
			public static CullingGroup.StateChanged operator +(CullingGroup.StateChanged A_0, CullingGroup.StateChanged A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<CullingGroup.StateChanged>();
			}

			// Token: 0x0600258B RID: 9611 RVA: 0x0001525A File Offset: 0x0001345A
			public static CullingGroup.StateChanged operator -(CullingGroup.StateChanged A_0, CullingGroup.StateChanged A_1)
			{
				Delegate delegate2;
				Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
				if (@delegate != null)
				{
					delegate2 = @delegate.Cast<CullingGroup.StateChanged>();
				}
				return delegate2;
			}

			// Token: 0x04001C5D RID: 7261
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x04001C5E RID: 7262
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_CullingGroupEvent_0;
		}

		// Token: 0x020003E2 RID: 994
		// (Invoke) Token: 0x0600258D RID: 9613
		private delegate void DisposeInternalDelegate(IntPtr @this);

		// Token: 0x020003E3 RID: 995
		// (Invoke) Token: 0x0600258F RID: 9615
		private delegate bool get_enabledDelegate(IntPtr @this);

		// Token: 0x020003E4 RID: 996
		// (Invoke) Token: 0x06002591 RID: 9617
		private delegate void set_enabledDelegate(IntPtr @this, bool value);

		// Token: 0x020003E5 RID: 997
		// (Invoke) Token: 0x06002593 RID: 9619
		private delegate IntPtr get_targetCameraDelegate(IntPtr @this);

		// Token: 0x020003E6 RID: 998
		// (Invoke) Token: 0x06002595 RID: 9621
		private delegate void set_targetCameraDelegate(IntPtr @this, IntPtr value);

		// Token: 0x020003E7 RID: 999
		// (Invoke) Token: 0x06002597 RID: 9623
		private delegate void SetBoundingSphereCountDelegate(IntPtr @this, int count);

		// Token: 0x020003E8 RID: 1000
		// (Invoke) Token: 0x06002599 RID: 9625
		private delegate void EraseSwapBackDelegate(IntPtr @this, int index);

		// Token: 0x020003E9 RID: 1001
		// (Invoke) Token: 0x0600259B RID: 9627
		private delegate int QueryIndicesDelegate(IntPtr @this, bool visible, int distanceIndex, CullingQueryOptions options, IntPtr result, int firstIndex);

		// Token: 0x020003EA RID: 1002
		// (Invoke) Token: 0x0600259D RID: 9629
		private delegate bool IsVisibleDelegate(IntPtr @this, int index);

		// Token: 0x020003EB RID: 1003
		// (Invoke) Token: 0x0600259F RID: 9631
		private delegate int GetDistanceDelegate(IntPtr @this, int index);

		// Token: 0x020003EC RID: 1004
		// (Invoke) Token: 0x060025A1 RID: 9633
		private delegate void SetBoundingDistancesDelegate(IntPtr @this, IntPtr distances);

		// Token: 0x020003ED RID: 1005
		// (Invoke) Token: 0x060025A3 RID: 9635
		private delegate void SetDistanceReferencePoint_InternalTransformDelegate(IntPtr @this, IntPtr transform);

		// Token: 0x020003EE RID: 1006
		// (Invoke) Token: 0x060025A5 RID: 9637
		private delegate IntPtr InitDelegate(IntPtr scripting);

		// Token: 0x020003EF RID: 1007
		// (Invoke) Token: 0x060025A7 RID: 9639
		private delegate void FinalizerFailureDelegate(IntPtr @this);

		// Token: 0x020003F0 RID: 1008
		// (Invoke) Token: 0x060025A9 RID: 9641
		private delegate void SetDistanceReferencePoint_InternalVector3_InjectedDelegate(IntPtr @this, IntPtr point);
	}
}
