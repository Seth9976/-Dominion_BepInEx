using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;

namespace UnityEngine.UI.CoroutineTween
{
	// Token: 0x02000049 RID: 73
	public class TweenRunner<T> : Object where T : new()
	{
		// Token: 0x0600087F RID: 2175 RVA: 0x00028208 File Offset: 0x00026408
		// Note: this type is marked as 'beforefieldinit'.
		static TweenRunner()
		{
			Il2CppClassPointerStore<TweenRunner<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("UnityEngine.UI.dll", "UnityEngine.UI.CoroutineTween", "TweenRunner`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TweenRunner<T>>.NativeClassPtr);
			TweenRunner<T>.NativeFieldInfoPtr_m_CoroutineContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TweenRunner<T>>.NativeClassPtr, "m_CoroutineContainer");
			TweenRunner<T>.NativeFieldInfoPtr_m_Tween = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TweenRunner<T>>.NativeClassPtr, "m_Tween");
			TweenRunner<T>.NativeMethodInfoPtr_Start_Private_Static_IEnumerator_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TweenRunner<T>>.NativeClassPtr, 100664544);
			TweenRunner<T>.NativeMethodInfoPtr_Init_Public_Void_MonoBehaviour_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TweenRunner<T>>.NativeClassPtr, 100664545);
			TweenRunner<T>.NativeMethodInfoPtr_StartTween_Public_Void_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TweenRunner<T>>.NativeClassPtr, 100664546);
			TweenRunner<T>.NativeMethodInfoPtr_StopTween_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TweenRunner<T>>.NativeClassPtr, 100664547);
			TweenRunner<T>.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TweenRunner<T>>.NativeClassPtr, 100664548);
		}

		// Token: 0x06000880 RID: 2176 RVA: 0x00028300 File Offset: 0x00026500
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 120458, XrefRangeEnd = 120464, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IEnumerator Start(T tweenInfo)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(T).IsValueType)
				{
					T t = tweenInfo;
					intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref tweenInfo;
				}
				ptr2 = intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(TweenRunner<T>.NativeMethodInfoPtr_Start_Private_Static_IEnumerator_T_0, 0, (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				IntPtr intPtr4 = intPtr2;
				return (intPtr4 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr4) : null;
			}
		}

		// Token: 0x06000881 RID: 2177 RVA: 0x0002837C File Offset: 0x0002657C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 5326, RefRangeEnd = 5327, XrefRangeStart = 5326, XrefRangeEnd = 5327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Init(MonoBehaviour coroutineContainer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(coroutineContainer);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TweenRunner<T>.NativeMethodInfoPtr_Init_Public_Void_MonoBehaviour_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000882 RID: 2178 RVA: 0x000283C0 File Offset: 0x000265C0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 120480, RefRangeEnd = 120481, XrefRangeStart = 120464, XrefRangeEnd = 120480, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StartTween(T info)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(T).IsValueType)
				{
					T t = info;
					intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref info;
				}
				ptr2 = intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(TweenRunner<T>.NativeMethodInfoPtr_StartTween_Public_Void_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			}
		}

		// Token: 0x06000883 RID: 2179 RVA: 0x00028438 File Offset: 0x00026638
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 120482, RefRangeEnd = 120483, XrefRangeStart = 120481, XrefRangeEnd = 120482, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StopTween()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TweenRunner<T>.NativeMethodInfoPtr_StopTween_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000884 RID: 2180 RVA: 0x0002846C File Offset: 0x0002666C
		[CallerCount(17)]
		[CachedScanResults(RefRangeStart = 44661, RefRangeEnd = 44678, XrefRangeStart = 44661, XrefRangeEnd = 44678, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TweenRunner()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TweenRunner<T>>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TweenRunner<T>.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000885 RID: 2181 RVA: 0x00004F04 File Offset: 0x00003104
		public TweenRunner(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170002E1 RID: 737
		// (get) Token: 0x06000886 RID: 2182 RVA: 0x000284A8 File Offset: 0x000266A8
		// (set) Token: 0x06000887 RID: 2183 RVA: 0x00004F0D File Offset: 0x0000310D
		public unsafe MonoBehaviour m_CoroutineContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TweenRunner<T>.NativeFieldInfoPtr_m_CoroutineContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MonoBehaviour>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TweenRunner<T>.NativeFieldInfoPtr_m_CoroutineContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002E2 RID: 738
		// (get) Token: 0x06000888 RID: 2184 RVA: 0x000284D8 File Offset: 0x000266D8
		// (set) Token: 0x06000889 RID: 2185 RVA: 0x00004F2C File Offset: 0x0000312C
		public unsafe IEnumerator m_Tween
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TweenRunner<T>.NativeFieldInfoPtr_m_Tween);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TweenRunner<T>.NativeFieldInfoPtr_m_Tween), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000673 RID: 1651
		private static readonly IntPtr NativeFieldInfoPtr_m_CoroutineContainer;

		// Token: 0x04000674 RID: 1652
		private static readonly IntPtr NativeFieldInfoPtr_m_Tween;

		// Token: 0x04000675 RID: 1653
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Static_IEnumerator_T_0;

		// Token: 0x04000676 RID: 1654
		private static readonly IntPtr NativeMethodInfoPtr_Init_Public_Void_MonoBehaviour_0;

		// Token: 0x04000677 RID: 1655
		private static readonly IntPtr NativeMethodInfoPtr_StartTween_Public_Void_T_0;

		// Token: 0x04000678 RID: 1656
		private static readonly IntPtr NativeMethodInfoPtr_StopTween_Public_Void_0;

		// Token: 0x04000679 RID: 1657
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020000BE RID: 190
		[ObfuscatedName("UnityEngine.UI.CoroutineTween.TweenRunner`1+<Start>d__2")]
		public sealed class _Start_d__2 : Object
		{
			// Token: 0x06000CC7 RID: 3271 RVA: 0x00037104 File Offset: 0x00035304
			// Note: this type is marked as 'beforefieldinit'.
			static _Start_d__2()
			{
				Il2CppClassPointerStore<TweenRunner<T>._Start_d__2>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TweenRunner<T>>.NativeClassPtr, "<Start>d__2"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TweenRunner<T>._Start_d__2>.NativeClassPtr);
				TweenRunner<T>._Start_d__2.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TweenRunner<T>._Start_d__2>.NativeClassPtr, "<>1__state");
				TweenRunner<T>._Start_d__2.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TweenRunner<T>._Start_d__2>.NativeClassPtr, "<>2__current");
				TweenRunner<T>._Start_d__2.NativeFieldInfoPtr_tweenInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TweenRunner<T>._Start_d__2>.NativeClassPtr, "tweenInfo");
				TweenRunner<T>._Start_d__2.NativeFieldInfoPtr__elapsedTime_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TweenRunner<T>._Start_d__2>.NativeClassPtr, "<elapsedTime>5__2");
				TweenRunner<T>._Start_d__2.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TweenRunner<T>._Start_d__2>.NativeClassPtr, 100665077);
				TweenRunner<T>._Start_d__2.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TweenRunner<T>._Start_d__2>.NativeClassPtr, 100665078);
				TweenRunner<T>._Start_d__2.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TweenRunner<T>._Start_d__2>.NativeClassPtr, 100665079);
				TweenRunner<T>._Start_d__2.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TweenRunner<T>._Start_d__2>.NativeClassPtr, 100665080);
				TweenRunner<T>._Start_d__2.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TweenRunner<T>._Start_d__2>.NativeClassPtr, 100665081);
				TweenRunner<T>._Start_d__2.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TweenRunner<T>._Start_d__2>.NativeClassPtr, 100665082);
			}

			// Token: 0x06000CC8 RID: 3272 RVA: 0x00037234 File Offset: 0x00035434
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _Start_d__2(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TweenRunner<T>._Start_d__2>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TweenRunner<T>._Start_d__2.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06000CC9 RID: 3273 RVA: 0x0003727C File Offset: 0x0003547C
			[CallerCount(3728)]
			[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TweenRunner<T>._Start_d__2.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000CCA RID: 3274 RVA: 0x000372B0 File Offset: 0x000354B0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 120446, XrefRangeEnd = 120453, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TweenRunner<T>._Start_d__2.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000429 RID: 1065
			// (get) Token: 0x06000CCB RID: 3275 RVA: 0x000372EC File Offset: 0x000354EC
			public unsafe Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(7)]
				[CachedScanResults(RefRangeStart = 5312, RefRangeEnd = 5319, XrefRangeStart = 5312, XrefRangeEnd = 5319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TweenRunner<T>._Start_d__2.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06000CCC RID: 3276 RVA: 0x0003732C File Offset: 0x0003552C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 120453, XrefRangeEnd = 120458, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TweenRunner<T>._Start_d__2.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x1700042A RID: 1066
			// (get) Token: 0x06000CCD RID: 3277 RVA: 0x00037360 File Offset: 0x00035560
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(7)]
				[CachedScanResults(RefRangeStart = 5312, RefRangeEnd = 5319, XrefRangeStart = 5312, XrefRangeEnd = 5319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TweenRunner<T>._Start_d__2.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06000CCE RID: 3278 RVA: 0x00006D19 File Offset: 0x00004F19
			public _Start_d__2(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000425 RID: 1061
			// (get) Token: 0x06000CCF RID: 3279 RVA: 0x000373A0 File Offset: 0x000355A0
			// (set) Token: 0x06000CD0 RID: 3280 RVA: 0x00006D22 File Offset: 0x00004F22
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TweenRunner<T>._Start_d__2.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TweenRunner<T>._Start_d__2.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000426 RID: 1062
			// (get) Token: 0x06000CD1 RID: 3281 RVA: 0x000373C8 File Offset: 0x000355C8
			// (set) Token: 0x06000CD2 RID: 3282 RVA: 0x00006D3D File Offset: 0x00004F3D
			public unsafe Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TweenRunner<T>._Start_d__2.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TweenRunner<T>._Start_d__2.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000427 RID: 1063
			// (get) Token: 0x06000CD3 RID: 3283 RVA: 0x000373F8 File Offset: 0x000355F8
			// (set) Token: 0x06000CD4 RID: 3284 RVA: 0x00037420 File Offset: 0x00035620
			public unsafe T tweenInfo
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TweenRunner<T>._Start_d__2.NativeFieldInfoPtr_tweenInfo);
					return IL2CPP.PointerToValueGeneric<T>(intPtr, true, false);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr intPtr2 = intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TweenRunner<T>._Start_d__2.NativeFieldInfoPtr_tweenInfo);
					Type typeFromHandle = typeof(T);
					if (!typeFromHandle.IsValueType)
					{
						if (!string.Equals(typeFromHandle.FullName, "System.String"))
						{
							IntPtr intPtr4;
							IntPtr intPtr3 = (intPtr4 = IL2CPP.Il2CppObjectBaseToPtr(value as Il2CppObjectBase));
							if (intPtr3 != 0)
							{
								intPtr4 = intPtr3;
								if (IL2CPP.il2cpp_class_is_valuetype(IL2CPP.il2cpp_object_get_class(intPtr3)))
								{
									IntPtr intPtr5 = intPtr3;
									cpblk(intPtr2, IL2CPP.il2cpp_object_unbox(intPtr3), IL2CPP.il2cpp_class_value_size(IL2CPP.il2cpp_object_get_class(intPtr5), (UIntPtr)0));
									return;
								}
							}
							IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr2, intPtr4);
						}
						else
						{
							IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr2, IL2CPP.ManagedStringToIl2Cpp(value as string));
						}
					}
					else
					{
						*intPtr2 = value;
					}
				}
			}

			// Token: 0x17000428 RID: 1064
			// (get) Token: 0x06000CD5 RID: 3285 RVA: 0x000374C8 File Offset: 0x000356C8
			// (set) Token: 0x06000CD6 RID: 3286 RVA: 0x00006D5C File Offset: 0x00004F5C
			public unsafe float _elapsedTime_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TweenRunner<T>._Start_d__2.NativeFieldInfoPtr__elapsedTime_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TweenRunner<T>._Start_d__2.NativeFieldInfoPtr__elapsedTime_5__2)) = value;
				}
			}

			// Token: 0x040009F7 RID: 2551
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040009F8 RID: 2552
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040009F9 RID: 2553
			private static readonly IntPtr NativeFieldInfoPtr_tweenInfo;

			// Token: 0x040009FA RID: 2554
			private static readonly IntPtr NativeFieldInfoPtr__elapsedTime_5__2;

			// Token: 0x040009FB RID: 2555
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040009FC RID: 2556
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040009FD RID: 2557
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040009FE RID: 2558
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040009FF RID: 2559
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000A00 RID: 2560
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
