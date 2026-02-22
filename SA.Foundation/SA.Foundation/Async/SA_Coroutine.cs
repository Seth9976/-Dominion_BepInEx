using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using SA.Foundation.Patterns;
using UnityEngine;

namespace SA.Foundation.Async
{
	// Token: 0x02000040 RID: 64
	public static class SA_Coroutine : global::Il2CppSystem.Object
	{
		// Token: 0x06000384 RID: 900 RVA: 0x00011EE4 File Offset: 0x000100E4
		// Note: this type is marked as 'beforefieldinit'.
		static SA_Coroutine()
		{
			Il2CppClassPointerStore<SA_Coroutine>.NativeClassPtr = IL2CPP.GetIl2CppClass("SA.Foundation.dll", "SA.Foundation.Async", "SA_Coroutine");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SA_Coroutine>.NativeClassPtr);
			SA_Coroutine.NativeMethodInfoPtr_Start_Public_Static_Coroutine_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_Coroutine>.NativeClassPtr, 100663844);
			SA_Coroutine.NativeMethodInfoPtr_Stop_Public_Static_Void_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_Coroutine>.NativeClassPtr, 100663845);
			SA_Coroutine.NativeMethodInfoPtr_AddCoroutineToQueue_Public_Static_Void_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_Coroutine>.NativeClassPtr, 100663846);
			SA_Coroutine.NativeMethodInfoPtr_WaitForEndOfFrame_Public_Static_Coroutine_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_Coroutine>.NativeClassPtr, 100663847);
			SA_Coroutine.NativeMethodInfoPtr_WaitForFixedUpdate_Public_Static_Coroutine_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_Coroutine>.NativeClassPtr, 100663848);
			SA_Coroutine.NativeMethodInfoPtr_WaitForSeconds_Public_Static_Coroutine_Single_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_Coroutine>.NativeClassPtr, 100663849);
			SA_Coroutine.NativeMethodInfoPtr_WaitForSecondsRandom_Public_Static_Coroutine_Single_Single_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_Coroutine>.NativeClassPtr, 100663850);
		}

		// Token: 0x06000385 RID: 901 RVA: 0x00011FA0 File Offset: 0x000101A0
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 107703, RefRangeEnd = 107708, XrefRangeStart = 107695, XrefRangeEnd = 107703, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Coroutine Start(IEnumerator routine)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(routine);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_Coroutine.NativeMethodInfoPtr_Start_Public_Static_Coroutine_IEnumerator_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr3) : null;
			}
		}

		// Token: 0x06000386 RID: 902 RVA: 0x00011FE4 File Offset: 0x000101E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 107708, XrefRangeEnd = 107716, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Stop(IEnumerator routine)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(routine);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_Coroutine.NativeMethodInfoPtr_Stop_Public_Static_Void_IEnumerator_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000387 RID: 903 RVA: 0x0001201C File Offset: 0x0001021C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 107716, XrefRangeEnd = 107724, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void AddCoroutineToQueue(IEnumerator coroutine)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(coroutine);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_Coroutine.NativeMethodInfoPtr_AddCoroutineToQueue_Public_Static_Void_IEnumerator_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000388 RID: 904 RVA: 0x00012054 File Offset: 0x00010254
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 107724, XrefRangeEnd = 107736, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Coroutine WaitForEndOfFrame(Action action)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(action);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_Coroutine.NativeMethodInfoPtr_WaitForEndOfFrame_Public_Static_Coroutine_Action_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr3) : null;
			}
		}

		// Token: 0x06000389 RID: 905 RVA: 0x00012098 File Offset: 0x00010298
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 107736, XrefRangeEnd = 107748, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Coroutine WaitForFixedUpdate(Action action)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(action);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_Coroutine.NativeMethodInfoPtr_WaitForFixedUpdate_Public_Static_Coroutine_Action_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr3) : null;
			}
		}

		// Token: 0x0600038A RID: 906 RVA: 0x000120DC File Offset: 0x000102DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 107748, XrefRangeEnd = 107760, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Coroutine WaitForSeconds(float seconds, Action action)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref seconds;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(action);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_Coroutine.NativeMethodInfoPtr_WaitForSeconds_Public_Static_Coroutine_Single_Action_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr3) : null;
		}

		// Token: 0x0600038B RID: 907 RVA: 0x00012130 File Offset: 0x00010330
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 107760, XrefRangeEnd = 107773, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Coroutine WaitForSecondsRandom(float min, float max, Action action)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref min;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref max;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(action);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_Coroutine.NativeMethodInfoPtr_WaitForSecondsRandom_Public_Static_Coroutine_Single_Single_Action_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr3) : null;
		}

		// Token: 0x0600038C RID: 908 RVA: 0x00002EAB File Offset: 0x000010AB
		public SA_Coroutine(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040002BE RID: 702
		private static readonly IntPtr NativeMethodInfoPtr_Start_Public_Static_Coroutine_IEnumerator_0;

		// Token: 0x040002BF RID: 703
		private static readonly IntPtr NativeMethodInfoPtr_Stop_Public_Static_Void_IEnumerator_0;

		// Token: 0x040002C0 RID: 704
		private static readonly IntPtr NativeMethodInfoPtr_AddCoroutineToQueue_Public_Static_Void_IEnumerator_0;

		// Token: 0x040002C1 RID: 705
		private static readonly IntPtr NativeMethodInfoPtr_WaitForEndOfFrame_Public_Static_Coroutine_Action_0;

		// Token: 0x040002C2 RID: 706
		private static readonly IntPtr NativeMethodInfoPtr_WaitForFixedUpdate_Public_Static_Coroutine_Action_0;

		// Token: 0x040002C3 RID: 707
		private static readonly IntPtr NativeMethodInfoPtr_WaitForSeconds_Public_Static_Coroutine_Single_Action_0;

		// Token: 0x040002C4 RID: 708
		private static readonly IntPtr NativeMethodInfoPtr_WaitForSecondsRandom_Public_Static_Coroutine_Single_Single_Action_0;

		// Token: 0x02000061 RID: 97
		public class SA_InternalCoroutine : SA_Singleton<SA_Coroutine.SA_InternalCoroutine>
		{
			// Token: 0x06000496 RID: 1174 RVA: 0x000153B8 File Offset: 0x000135B8
			// Note: this type is marked as 'beforefieldinit'.
			static SA_InternalCoroutine()
			{
				Il2CppClassPointerStore<SA_Coroutine.SA_InternalCoroutine>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SA_Coroutine>.NativeClassPtr, "SA_InternalCoroutine");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SA_Coroutine.SA_InternalCoroutine>.NativeClassPtr);
				SA_Coroutine.SA_InternalCoroutine.NativeMethodInfoPtr_MonoStartCoroutine_Public_Coroutine_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_Coroutine.SA_InternalCoroutine>.NativeClassPtr, 100663940);
				SA_Coroutine.SA_InternalCoroutine.NativeMethodInfoPtr_MonoStopCoroutine_Public_Void_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_Coroutine.SA_InternalCoroutine>.NativeClassPtr, 100663941);
				SA_Coroutine.SA_InternalCoroutine.NativeMethodInfoPtr_StartInstruction_Public_Coroutine_YieldInstruction_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_Coroutine.SA_InternalCoroutine>.NativeClassPtr, 100663942);
				SA_Coroutine.SA_InternalCoroutine.NativeMethodInfoPtr_RunActionAfterInstruction_Private_IEnumerator_YieldInstruction_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_Coroutine.SA_InternalCoroutine>.NativeClassPtr, 100663943);
				SA_Coroutine.SA_InternalCoroutine.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_Coroutine.SA_InternalCoroutine>.NativeClassPtr, 100663944);
			}

			// Token: 0x06000497 RID: 1175 RVA: 0x00015448 File Offset: 0x00013648
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 107617, RefRangeEnd = 107618, XrefRangeStart = 107616, XrefRangeEnd = 107617, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Coroutine MonoStartCoroutine(IEnumerator routine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(routine);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_Coroutine.SA_InternalCoroutine.NativeMethodInfoPtr_MonoStartCoroutine_Public_Coroutine_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr3) : null;
				}
			}

			// Token: 0x06000498 RID: 1176 RVA: 0x00015498 File Offset: 0x00013698
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 107619, RefRangeEnd = 107620, XrefRangeStart = 107618, XrefRangeEnd = 107619, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MonoStopCoroutine(IEnumerator routine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(routine);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_Coroutine.SA_InternalCoroutine.NativeMethodInfoPtr_MonoStopCoroutine_Public_Void_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06000499 RID: 1177 RVA: 0x000154DC File Offset: 0x000136DC
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 107625, RefRangeEnd = 107629, XrefRangeStart = 107620, XrefRangeEnd = 107625, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Coroutine StartInstruction(YieldInstruction instruction, Action action)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(instruction);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(action);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_Coroutine.SA_InternalCoroutine.NativeMethodInfoPtr_StartInstruction_Public_Coroutine_YieldInstruction_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr3) : null;
			}

			// Token: 0x0600049A RID: 1178 RVA: 0x00015540 File Offset: 0x00013740
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 107629, XrefRangeEnd = 107633, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator RunActionAfterInstruction(YieldInstruction instruction, Action action)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(instruction);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(action);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_Coroutine.SA_InternalCoroutine.NativeMethodInfoPtr_RunActionAfterInstruction_Private_IEnumerator_YieldInstruction_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600049B RID: 1179 RVA: 0x000155A4 File Offset: 0x000137A4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 107633, XrefRangeEnd = 107639, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe SA_InternalCoroutine()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SA_Coroutine.SA_InternalCoroutine>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_Coroutine.SA_InternalCoroutine.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600049C RID: 1180 RVA: 0x000035E3 File Offset: 0x000017E3
			public SA_InternalCoroutine(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x0400036E RID: 878
			private static readonly IntPtr NativeMethodInfoPtr_MonoStartCoroutine_Public_Coroutine_IEnumerator_0;

			// Token: 0x0400036F RID: 879
			private static readonly IntPtr NativeMethodInfoPtr_MonoStopCoroutine_Public_Void_IEnumerator_0;

			// Token: 0x04000370 RID: 880
			private static readonly IntPtr NativeMethodInfoPtr_StartInstruction_Public_Coroutine_YieldInstruction_Action_0;

			// Token: 0x04000371 RID: 881
			private static readonly IntPtr NativeMethodInfoPtr_RunActionAfterInstruction_Private_IEnumerator_YieldInstruction_Action_0;

			// Token: 0x04000372 RID: 882
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x02000065 RID: 101
			[ObfuscatedName("SA.Foundation.Async.SA_Coroutine+SA_InternalCoroutine+<RunActionAfterInstruction>d__3")]
			public sealed class _RunActionAfterInstruction_d__3 : global::Il2CppSystem.Object
			{
				// Token: 0x060004AD RID: 1197 RVA: 0x00015964 File Offset: 0x00013B64
				// Note: this type is marked as 'beforefieldinit'.
				static _RunActionAfterInstruction_d__3()
				{
					Il2CppClassPointerStore<SA_Coroutine.SA_InternalCoroutine._RunActionAfterInstruction_d__3>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SA_Coroutine.SA_InternalCoroutine>.NativeClassPtr, "<RunActionAfterInstruction>d__3");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SA_Coroutine.SA_InternalCoroutine._RunActionAfterInstruction_d__3>.NativeClassPtr);
					SA_Coroutine.SA_InternalCoroutine._RunActionAfterInstruction_d__3.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SA_Coroutine.SA_InternalCoroutine._RunActionAfterInstruction_d__3>.NativeClassPtr, "<>1__state");
					SA_Coroutine.SA_InternalCoroutine._RunActionAfterInstruction_d__3.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SA_Coroutine.SA_InternalCoroutine._RunActionAfterInstruction_d__3>.NativeClassPtr, "<>2__current");
					SA_Coroutine.SA_InternalCoroutine._RunActionAfterInstruction_d__3.NativeFieldInfoPtr_instruction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SA_Coroutine.SA_InternalCoroutine._RunActionAfterInstruction_d__3>.NativeClassPtr, "instruction");
					SA_Coroutine.SA_InternalCoroutine._RunActionAfterInstruction_d__3.NativeFieldInfoPtr_action = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SA_Coroutine.SA_InternalCoroutine._RunActionAfterInstruction_d__3>.NativeClassPtr, "action");
					SA_Coroutine.SA_InternalCoroutine._RunActionAfterInstruction_d__3.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_Coroutine.SA_InternalCoroutine._RunActionAfterInstruction_d__3>.NativeClassPtr, 100663953);
					SA_Coroutine.SA_InternalCoroutine._RunActionAfterInstruction_d__3.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_Coroutine.SA_InternalCoroutine._RunActionAfterInstruction_d__3>.NativeClassPtr, 100663954);
					SA_Coroutine.SA_InternalCoroutine._RunActionAfterInstruction_d__3.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_Coroutine.SA_InternalCoroutine._RunActionAfterInstruction_d__3>.NativeClassPtr, 100663955);
					SA_Coroutine.SA_InternalCoroutine._RunActionAfterInstruction_d__3.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_Coroutine.SA_InternalCoroutine._RunActionAfterInstruction_d__3>.NativeClassPtr, 100663956);
					SA_Coroutine.SA_InternalCoroutine._RunActionAfterInstruction_d__3.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_Coroutine.SA_InternalCoroutine._RunActionAfterInstruction_d__3>.NativeClassPtr, 100663957);
					SA_Coroutine.SA_InternalCoroutine._RunActionAfterInstruction_d__3.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_Coroutine.SA_InternalCoroutine._RunActionAfterInstruction_d__3>.NativeClassPtr, 100663958);
				}

				// Token: 0x060004AE RID: 1198 RVA: 0x00015A58 File Offset: 0x00013C58
				[CallerCount(208)]
				[CachedScanResults(RefRangeStart = 8591, RefRangeEnd = 8799, XrefRangeStart = 8591, XrefRangeEnd = 8799, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe _RunActionAfterInstruction_d__3(int <>1__state)
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SA_Coroutine.SA_InternalCoroutine._RunActionAfterInstruction_d__3>.NativeClassPtr))
				{
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref <>1__state;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_Coroutine.SA_InternalCoroutine._RunActionAfterInstruction_d__3.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}

				// Token: 0x060004AF RID: 1199 RVA: 0x00015AA0 File Offset: 0x00013CA0
				[CallerCount(3728)]
				[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_IDisposable_Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_Coroutine.SA_InternalCoroutine._RunActionAfterInstruction_d__3.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x060004B0 RID: 1200 RVA: 0x00015AD4 File Offset: 0x00013CD4
				[CallerCount(0)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_Coroutine.SA_InternalCoroutine._RunActionAfterInstruction_d__3.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x170000FE RID: 254
				// (get) Token: 0x060004B1 RID: 1201 RVA: 0x00015B10 File Offset: 0x00013D10
				public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
				{
					[CallerCount(7)]
					[CachedScanResults(RefRangeStart = 5312, RefRangeEnd = 5319, XrefRangeStart = 5312, XrefRangeEnd = 5319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_Coroutine.SA_InternalCoroutine._RunActionAfterInstruction_d__3.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x060004B2 RID: 1202 RVA: 0x00015B50 File Offset: 0x00013D50
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 107611, XrefRangeEnd = 107616, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_Coroutine.SA_InternalCoroutine._RunActionAfterInstruction_d__3.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x170000FF RID: 255
				// (get) Token: 0x060004B3 RID: 1203 RVA: 0x00015B84 File Offset: 0x00013D84
				public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
				{
					[CallerCount(7)]
					[CachedScanResults(RefRangeStart = 5312, RefRangeEnd = 5319, XrefRangeStart = 5312, XrefRangeEnd = 5319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_Coroutine.SA_InternalCoroutine._RunActionAfterInstruction_d__3.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x060004B4 RID: 1204 RVA: 0x0000362F File Offset: 0x0000182F
				public _RunActionAfterInstruction_d__3(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x170000FA RID: 250
				// (get) Token: 0x060004B5 RID: 1205 RVA: 0x00015BC4 File Offset: 0x00013DC4
				// (set) Token: 0x060004B6 RID: 1206 RVA: 0x00003638 File Offset: 0x00001838
				public unsafe int __1__state
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SA_Coroutine.SA_InternalCoroutine._RunActionAfterInstruction_d__3.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SA_Coroutine.SA_InternalCoroutine._RunActionAfterInstruction_d__3.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x170000FB RID: 251
				// (get) Token: 0x060004B7 RID: 1207 RVA: 0x00015BEC File Offset: 0x00013DEC
				// (set) Token: 0x060004B8 RID: 1208 RVA: 0x00003653 File Offset: 0x00001853
				public unsafe global::Il2CppSystem.Object __2__current
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SA_Coroutine.SA_InternalCoroutine._RunActionAfterInstruction_d__3.NativeFieldInfoPtr___2__current);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SA_Coroutine.SA_InternalCoroutine._RunActionAfterInstruction_d__3.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x170000FC RID: 252
				// (get) Token: 0x060004B9 RID: 1209 RVA: 0x00015C1C File Offset: 0x00013E1C
				// (set) Token: 0x060004BA RID: 1210 RVA: 0x00003672 File Offset: 0x00001872
				public unsafe YieldInstruction instruction
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SA_Coroutine.SA_InternalCoroutine._RunActionAfterInstruction_d__3.NativeFieldInfoPtr_instruction);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<YieldInstruction>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SA_Coroutine.SA_InternalCoroutine._RunActionAfterInstruction_d__3.NativeFieldInfoPtr_instruction), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x170000FD RID: 253
				// (get) Token: 0x060004BB RID: 1211 RVA: 0x00015C4C File Offset: 0x00013E4C
				// (set) Token: 0x060004BC RID: 1212 RVA: 0x00003691 File Offset: 0x00001891
				public unsafe Action action
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SA_Coroutine.SA_InternalCoroutine._RunActionAfterInstruction_d__3.NativeFieldInfoPtr_action);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SA_Coroutine.SA_InternalCoroutine._RunActionAfterInstruction_d__3.NativeFieldInfoPtr_action), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x0400037D RID: 893
				private static readonly IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x0400037E RID: 894
				private static readonly IntPtr NativeFieldInfoPtr___2__current;

				// Token: 0x0400037F RID: 895
				private static readonly IntPtr NativeFieldInfoPtr_instruction;

				// Token: 0x04000380 RID: 896
				private static readonly IntPtr NativeFieldInfoPtr_action;

				// Token: 0x04000381 RID: 897
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

				// Token: 0x04000382 RID: 898
				private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

				// Token: 0x04000383 RID: 899
				private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

				// Token: 0x04000384 RID: 900
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x04000385 RID: 901
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

				// Token: 0x04000386 RID: 902
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
			}
		}

		// Token: 0x02000062 RID: 98
		public class CoroutineQueue : SA_Singleton<SA_Coroutine.CoroutineQueue>
		{
			// Token: 0x0600049D RID: 1181 RVA: 0x000155E0 File Offset: 0x000137E0
			// Note: this type is marked as 'beforefieldinit'.
			static CoroutineQueue()
			{
				Il2CppClassPointerStore<SA_Coroutine.CoroutineQueue>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SA_Coroutine>.NativeClassPtr, "CoroutineQueue");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SA_Coroutine.CoroutineQueue>.NativeClassPtr);
				SA_Coroutine.CoroutineQueue.NativeFieldInfoPtr_m_coroutineQueue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SA_Coroutine.CoroutineQueue>.NativeClassPtr, "m_coroutineQueue");
				SA_Coroutine.CoroutineQueue.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_Coroutine.CoroutineQueue>.NativeClassPtr, 100663945);
				SA_Coroutine.CoroutineQueue.NativeMethodInfoPtr_AddCoroutine_Public_Void_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_Coroutine.CoroutineQueue>.NativeClassPtr, 100663946);
				SA_Coroutine.CoroutineQueue.NativeMethodInfoPtr_CoroutineLoop_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_Coroutine.CoroutineQueue>.NativeClassPtr, 100663947);
				SA_Coroutine.CoroutineQueue.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_Coroutine.CoroutineQueue>.NativeClassPtr, 100663948);
			}

			// Token: 0x0600049E RID: 1182 RVA: 0x00015670 File Offset: 0x00013870
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 107647, XrefRangeEnd = 107655, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void Awake()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SA_Coroutine.CoroutineQueue.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600049F RID: 1183 RVA: 0x000156AC File Offset: 0x000138AC
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 107659, RefRangeEnd = 107660, XrefRangeStart = 107655, XrefRangeEnd = 107659, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void AddCoroutine(IEnumerator coroutine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(coroutine);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_Coroutine.CoroutineQueue.NativeMethodInfoPtr_AddCoroutine_Public_Void_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060004A0 RID: 1184 RVA: 0x000156F0 File Offset: 0x000138F0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 107660, XrefRangeEnd = 107664, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator CoroutineLoop()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_Coroutine.CoroutineQueue.NativeMethodInfoPtr_CoroutineLoop_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x060004A1 RID: 1185 RVA: 0x00015730 File Offset: 0x00013930
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 107664, XrefRangeEnd = 107695, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe CoroutineQueue()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SA_Coroutine.CoroutineQueue>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_Coroutine.CoroutineQueue.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060004A2 RID: 1186 RVA: 0x000035EC File Offset: 0x000017EC
			public CoroutineQueue(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170000F8 RID: 248
			// (get) Token: 0x060004A3 RID: 1187 RVA: 0x0001576C File Offset: 0x0001396C
			// (set) Token: 0x060004A4 RID: 1188 RVA: 0x000035F5 File Offset: 0x000017F5
			public unsafe Queue<IEnumerator> m_coroutineQueue
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SA_Coroutine.CoroutineQueue.NativeFieldInfoPtr_m_coroutineQueue);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Queue<IEnumerator>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SA_Coroutine.CoroutineQueue.NativeFieldInfoPtr_m_coroutineQueue), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000373 RID: 883
			private static readonly IntPtr NativeFieldInfoPtr_m_coroutineQueue;

			// Token: 0x04000374 RID: 884
			private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0;

			// Token: 0x04000375 RID: 885
			private static readonly IntPtr NativeMethodInfoPtr_AddCoroutine_Public_Void_IEnumerator_0;

			// Token: 0x04000376 RID: 886
			private static readonly IntPtr NativeMethodInfoPtr_CoroutineLoop_Private_IEnumerator_0;

			// Token: 0x04000377 RID: 887
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x02000066 RID: 102
			[ObfuscatedName("SA.Foundation.Async.SA_Coroutine+CoroutineQueue+<CoroutineLoop>d__3")]
			public sealed class _CoroutineLoop_d__3 : global::Il2CppSystem.Object
			{
				// Token: 0x060004BD RID: 1213 RVA: 0x00015C7C File Offset: 0x00013E7C
				// Note: this type is marked as 'beforefieldinit'.
				static _CoroutineLoop_d__3()
				{
					Il2CppClassPointerStore<SA_Coroutine.CoroutineQueue._CoroutineLoop_d__3>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SA_Coroutine.CoroutineQueue>.NativeClassPtr, "<CoroutineLoop>d__3");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SA_Coroutine.CoroutineQueue._CoroutineLoop_d__3>.NativeClassPtr);
					SA_Coroutine.CoroutineQueue._CoroutineLoop_d__3.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SA_Coroutine.CoroutineQueue._CoroutineLoop_d__3>.NativeClassPtr, "<>1__state");
					SA_Coroutine.CoroutineQueue._CoroutineLoop_d__3.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SA_Coroutine.CoroutineQueue._CoroutineLoop_d__3>.NativeClassPtr, "<>2__current");
					SA_Coroutine.CoroutineQueue._CoroutineLoop_d__3.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SA_Coroutine.CoroutineQueue._CoroutineLoop_d__3>.NativeClassPtr, "<>4__this");
					SA_Coroutine.CoroutineQueue._CoroutineLoop_d__3.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_Coroutine.CoroutineQueue._CoroutineLoop_d__3>.NativeClassPtr, 100663959);
					SA_Coroutine.CoroutineQueue._CoroutineLoop_d__3.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_Coroutine.CoroutineQueue._CoroutineLoop_d__3>.NativeClassPtr, 100663960);
					SA_Coroutine.CoroutineQueue._CoroutineLoop_d__3.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_Coroutine.CoroutineQueue._CoroutineLoop_d__3>.NativeClassPtr, 100663961);
					SA_Coroutine.CoroutineQueue._CoroutineLoop_d__3.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_Coroutine.CoroutineQueue._CoroutineLoop_d__3>.NativeClassPtr, 100663962);
					SA_Coroutine.CoroutineQueue._CoroutineLoop_d__3.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_Coroutine.CoroutineQueue._CoroutineLoop_d__3>.NativeClassPtr, 100663963);
					SA_Coroutine.CoroutineQueue._CoroutineLoop_d__3.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_Coroutine.CoroutineQueue._CoroutineLoop_d__3>.NativeClassPtr, 100663964);
				}

				// Token: 0x060004BE RID: 1214 RVA: 0x00015D5C File Offset: 0x00013F5C
				[CallerCount(208)]
				[CachedScanResults(RefRangeStart = 8591, RefRangeEnd = 8799, XrefRangeStart = 8591, XrefRangeEnd = 8799, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe _CoroutineLoop_d__3(int <>1__state)
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SA_Coroutine.CoroutineQueue._CoroutineLoop_d__3>.NativeClassPtr))
				{
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref <>1__state;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_Coroutine.CoroutineQueue._CoroutineLoop_d__3.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}

				// Token: 0x060004BF RID: 1215 RVA: 0x00015DA4 File Offset: 0x00013FA4
				[CallerCount(3728)]
				[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_IDisposable_Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_Coroutine.CoroutineQueue._CoroutineLoop_d__3.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x060004C0 RID: 1216 RVA: 0x00015DD8 File Offset: 0x00013FD8
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 107639, XrefRangeEnd = 107642, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_Coroutine.CoroutineQueue._CoroutineLoop_d__3.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x17000103 RID: 259
				// (get) Token: 0x060004C1 RID: 1217 RVA: 0x00015E14 File Offset: 0x00014014
				public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
				{
					[CallerCount(7)]
					[CachedScanResults(RefRangeStart = 5312, RefRangeEnd = 5319, XrefRangeStart = 5312, XrefRangeEnd = 5319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_Coroutine.CoroutineQueue._CoroutineLoop_d__3.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x060004C2 RID: 1218 RVA: 0x00015E54 File Offset: 0x00014054
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 107642, XrefRangeEnd = 107647, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_Coroutine.CoroutineQueue._CoroutineLoop_d__3.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x17000104 RID: 260
				// (get) Token: 0x060004C3 RID: 1219 RVA: 0x00015E88 File Offset: 0x00014088
				public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
				{
					[CallerCount(7)]
					[CachedScanResults(RefRangeStart = 5312, RefRangeEnd = 5319, XrefRangeStart = 5312, XrefRangeEnd = 5319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_Coroutine.CoroutineQueue._CoroutineLoop_d__3.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x060004C4 RID: 1220 RVA: 0x000036B0 File Offset: 0x000018B0
				public _CoroutineLoop_d__3(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x17000100 RID: 256
				// (get) Token: 0x060004C5 RID: 1221 RVA: 0x00015EC8 File Offset: 0x000140C8
				// (set) Token: 0x060004C6 RID: 1222 RVA: 0x000036B9 File Offset: 0x000018B9
				public unsafe int __1__state
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SA_Coroutine.CoroutineQueue._CoroutineLoop_d__3.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SA_Coroutine.CoroutineQueue._CoroutineLoop_d__3.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x17000101 RID: 257
				// (get) Token: 0x060004C7 RID: 1223 RVA: 0x00015EF0 File Offset: 0x000140F0
				// (set) Token: 0x060004C8 RID: 1224 RVA: 0x000036D4 File Offset: 0x000018D4
				public unsafe global::Il2CppSystem.Object __2__current
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SA_Coroutine.CoroutineQueue._CoroutineLoop_d__3.NativeFieldInfoPtr___2__current);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SA_Coroutine.CoroutineQueue._CoroutineLoop_d__3.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17000102 RID: 258
				// (get) Token: 0x060004C9 RID: 1225 RVA: 0x00015F20 File Offset: 0x00014120
				// (set) Token: 0x060004CA RID: 1226 RVA: 0x000036F3 File Offset: 0x000018F3
				public unsafe SA_Coroutine.CoroutineQueue __4__this
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SA_Coroutine.CoroutineQueue._CoroutineLoop_d__3.NativeFieldInfoPtr___4__this);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<SA_Coroutine.CoroutineQueue>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SA_Coroutine.CoroutineQueue._CoroutineLoop_d__3.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x04000387 RID: 903
				private static readonly IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x04000388 RID: 904
				private static readonly IntPtr NativeFieldInfoPtr___2__current;

				// Token: 0x04000389 RID: 905
				private static readonly IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x0400038A RID: 906
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

				// Token: 0x0400038B RID: 907
				private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400038C RID: 908
				private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

				// Token: 0x0400038D RID: 909
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x0400038E RID: 910
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400038F RID: 911
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
			}
		}
	}
}
