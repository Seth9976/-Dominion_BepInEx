using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnityEngine;

namespace TMPro
{
	// Token: 0x0200002A RID: 42
	public class TweenRunner<T> : global::Il2CppSystem.Object where T : new()
	{
		// Token: 0x060003D1 RID: 977 RVA: 0x00015E68 File Offset: 0x00014068
		// Note: this type is marked as 'beforefieldinit'.
		static TweenRunner()
		{
			Il2CppClassPointerStore<TweenRunner<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("Unity.TextMeshPro.dll", "TMPro", "TweenRunner`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TweenRunner<T>>.NativeClassPtr);
			TweenRunner<T>.NativeFieldInfoPtr_m_CoroutineContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TweenRunner<T>>.NativeClassPtr, "m_CoroutineContainer");
			TweenRunner<T>.NativeFieldInfoPtr_m_Tween = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TweenRunner<T>>.NativeClassPtr, "m_Tween");
			TweenRunner<T>.NativeMethodInfoPtr_Start_Private_Static_IEnumerator_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TweenRunner<T>>.NativeClassPtr, 100663642);
			TweenRunner<T>.NativeMethodInfoPtr_Init_Public_Void_MonoBehaviour_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TweenRunner<T>>.NativeClassPtr, 100663643);
			TweenRunner<T>.NativeMethodInfoPtr_StartTween_Public_Void_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TweenRunner<T>>.NativeClassPtr, 100663644);
			TweenRunner<T>.NativeMethodInfoPtr_StopTween_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TweenRunner<T>>.NativeClassPtr, 100663645);
			TweenRunner<T>.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TweenRunner<T>>.NativeClassPtr, 100663646);
		}

		// Token: 0x060003D2 RID: 978 RVA: 0x00015F60 File Offset: 0x00014160
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137721, XrefRangeEnd = 137727, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

		// Token: 0x060003D3 RID: 979 RVA: 0x00015FDC File Offset: 0x000141DC
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

		// Token: 0x060003D4 RID: 980 RVA: 0x00016020 File Offset: 0x00014220
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 137743, RefRangeEnd = 137744, XrefRangeStart = 137727, XrefRangeEnd = 137743, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

		// Token: 0x060003D5 RID: 981 RVA: 0x00016098 File Offset: 0x00014298
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 120482, RefRangeEnd = 120483, XrefRangeStart = 120482, XrefRangeEnd = 120483, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StopTween()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TweenRunner<T>.NativeMethodInfoPtr_StopTween_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003D6 RID: 982 RVA: 0x000160CC File Offset: 0x000142CC
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

		// Token: 0x060003D7 RID: 983 RVA: 0x00003F0F File Offset: 0x0000210F
		public TweenRunner(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700014B RID: 331
		// (get) Token: 0x060003D8 RID: 984 RVA: 0x00016108 File Offset: 0x00014308
		// (set) Token: 0x060003D9 RID: 985 RVA: 0x00003F18 File Offset: 0x00002118
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

		// Token: 0x1700014C RID: 332
		// (get) Token: 0x060003DA RID: 986 RVA: 0x00016138 File Offset: 0x00014338
		// (set) Token: 0x060003DB RID: 987 RVA: 0x00003F37 File Offset: 0x00002137
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

		// Token: 0x040002CC RID: 716
		private static readonly IntPtr NativeFieldInfoPtr_m_CoroutineContainer;

		// Token: 0x040002CD RID: 717
		private static readonly IntPtr NativeFieldInfoPtr_m_Tween;

		// Token: 0x040002CE RID: 718
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Static_IEnumerator_T_0;

		// Token: 0x040002CF RID: 719
		private static readonly IntPtr NativeMethodInfoPtr_Init_Public_Void_MonoBehaviour_0;

		// Token: 0x040002D0 RID: 720
		private static readonly IntPtr NativeMethodInfoPtr_StartTween_Public_Void_T_0;

		// Token: 0x040002D1 RID: 721
		private static readonly IntPtr NativeMethodInfoPtr_StopTween_Public_Void_0;

		// Token: 0x040002D2 RID: 722
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0200007D RID: 125
		[ObfuscatedName("TMPro.TweenRunner`1+<Start>d__2")]
		public sealed class _Start_d__2 : global::Il2CppSystem.Object
		{
			// Token: 0x06000EA2 RID: 3746 RVA: 0x0003B070 File Offset: 0x00039270
			// Note: this type is marked as 'beforefieldinit'.
			static _Start_d__2()
			{
				Il2CppClassPointerStore<TweenRunner<T>._Start_d__2>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TweenRunner<T>>.NativeClassPtr, "<Start>d__2"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TweenRunner<T>._Start_d__2>.NativeClassPtr);
				TweenRunner<T>._Start_d__2.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TweenRunner<T>._Start_d__2>.NativeClassPtr, "<>1__state");
				TweenRunner<T>._Start_d__2.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TweenRunner<T>._Start_d__2>.NativeClassPtr, "<>2__current");
				TweenRunner<T>._Start_d__2.NativeFieldInfoPtr_tweenInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TweenRunner<T>._Start_d__2>.NativeClassPtr, "tweenInfo");
				TweenRunner<T>._Start_d__2.NativeFieldInfoPtr__elapsedTime_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TweenRunner<T>._Start_d__2>.NativeClassPtr, "<elapsedTime>5__2");
				TweenRunner<T>._Start_d__2.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TweenRunner<T>._Start_d__2>.NativeClassPtr, 100664799);
				TweenRunner<T>._Start_d__2.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TweenRunner<T>._Start_d__2>.NativeClassPtr, 100664800);
				TweenRunner<T>._Start_d__2.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TweenRunner<T>._Start_d__2>.NativeClassPtr, 100664801);
				TweenRunner<T>._Start_d__2.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TweenRunner<T>._Start_d__2>.NativeClassPtr, 100664802);
				TweenRunner<T>._Start_d__2.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TweenRunner<T>._Start_d__2>.NativeClassPtr, 100664803);
				TweenRunner<T>._Start_d__2.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TweenRunner<T>._Start_d__2>.NativeClassPtr, 100664804);
			}

			// Token: 0x06000EA3 RID: 3747 RVA: 0x0003B1A0 File Offset: 0x000393A0
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

			// Token: 0x06000EA4 RID: 3748 RVA: 0x0003B1E8 File Offset: 0x000393E8
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

			// Token: 0x06000EA5 RID: 3749 RVA: 0x0003B21C File Offset: 0x0003941C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137709, XrefRangeEnd = 137716, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TweenRunner<T>._Start_d__2.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x1700056A RID: 1386
			// (get) Token: 0x06000EA6 RID: 3750 RVA: 0x0003B258 File Offset: 0x00039458
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
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
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06000EA7 RID: 3751 RVA: 0x0003B298 File Offset: 0x00039498
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137716, XrefRangeEnd = 137721, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TweenRunner<T>._Start_d__2.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x1700056B RID: 1387
			// (get) Token: 0x06000EA8 RID: 3752 RVA: 0x0003B2CC File Offset: 0x000394CC
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
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
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06000EA9 RID: 3753 RVA: 0x00008E83 File Offset: 0x00007083
			public _Start_d__2(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000566 RID: 1382
			// (get) Token: 0x06000EAA RID: 3754 RVA: 0x0003B30C File Offset: 0x0003950C
			// (set) Token: 0x06000EAB RID: 3755 RVA: 0x00008E8C File Offset: 0x0000708C
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

			// Token: 0x17000567 RID: 1383
			// (get) Token: 0x06000EAC RID: 3756 RVA: 0x0003B334 File Offset: 0x00039534
			// (set) Token: 0x06000EAD RID: 3757 RVA: 0x00008EA7 File Offset: 0x000070A7
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TweenRunner<T>._Start_d__2.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TweenRunner<T>._Start_d__2.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000568 RID: 1384
			// (get) Token: 0x06000EAE RID: 3758 RVA: 0x0003B364 File Offset: 0x00039564
			// (set) Token: 0x06000EAF RID: 3759 RVA: 0x0003B38C File Offset: 0x0003958C
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

			// Token: 0x17000569 RID: 1385
			// (get) Token: 0x06000EB0 RID: 3760 RVA: 0x0003B434 File Offset: 0x00039634
			// (set) Token: 0x06000EB1 RID: 3761 RVA: 0x00008EC6 File Offset: 0x000070C6
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

			// Token: 0x04000BA1 RID: 2977
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04000BA2 RID: 2978
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04000BA3 RID: 2979
			private static readonly IntPtr NativeFieldInfoPtr_tweenInfo;

			// Token: 0x04000BA4 RID: 2980
			private static readonly IntPtr NativeFieldInfoPtr__elapsedTime_5__2;

			// Token: 0x04000BA5 RID: 2981
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04000BA6 RID: 2982
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000BA7 RID: 2983
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04000BA8 RID: 2984
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04000BA9 RID: 2985
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000BAA RID: 2986
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
