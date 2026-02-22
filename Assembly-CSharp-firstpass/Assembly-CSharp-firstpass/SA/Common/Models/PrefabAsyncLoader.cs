using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnityEngine;

namespace SA.Common.Models
{
	// Token: 0x02000317 RID: 791
	public class PrefabAsyncLoader : MonoBehaviour
	{
		// Token: 0x06002D7A RID: 11642 RVA: 0x000C1E28 File Offset: 0x000C0028
		// Note: this type is marked as 'beforefieldinit'.
		static PrefabAsyncLoader()
		{
			Il2CppClassPointerStore<PrefabAsyncLoader>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "SA.Common.Models", "PrefabAsyncLoader");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PrefabAsyncLoader>.NativeClassPtr);
			PrefabAsyncLoader.NativeFieldInfoPtr_PrefabPath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrefabAsyncLoader>.NativeClassPtr, "PrefabPath");
			PrefabAsyncLoader.NativeFieldInfoPtr_ObjectLoadedAction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrefabAsyncLoader>.NativeClassPtr, "ObjectLoadedAction");
			PrefabAsyncLoader.NativeMethodInfoPtr_add_ObjectLoadedAction_Public_add_Void_Action_1_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefabAsyncLoader>.NativeClassPtr, 100669235);
			PrefabAsyncLoader.NativeMethodInfoPtr_remove_ObjectLoadedAction_Public_rem_Void_Action_1_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefabAsyncLoader>.NativeClassPtr, 100669236);
			PrefabAsyncLoader.NativeMethodInfoPtr_Create_Public_Static_PrefabAsyncLoader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefabAsyncLoader>.NativeClassPtr, 100669237);
			PrefabAsyncLoader.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefabAsyncLoader>.NativeClassPtr, 100669238);
			PrefabAsyncLoader.NativeMethodInfoPtr_LoadAsync_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefabAsyncLoader>.NativeClassPtr, 100669239);
			PrefabAsyncLoader.NativeMethodInfoPtr_Load_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefabAsyncLoader>.NativeClassPtr, 100669240);
			PrefabAsyncLoader.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefabAsyncLoader>.NativeClassPtr, 100669241);
		}

		// Token: 0x06002D7B RID: 11643 RVA: 0x000C1F0C File Offset: 0x000C010C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 212540, RefRangeEnd = 212541, XrefRangeStart = 212536, XrefRangeEnd = 212540, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void add_ObjectLoadedAction(Action<GameObject> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PrefabAsyncLoader.NativeMethodInfoPtr_add_ObjectLoadedAction_Public_add_Void_Action_1_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002D7C RID: 11644 RVA: 0x000C1F50 File Offset: 0x000C0150
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 212541, XrefRangeEnd = 212545, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void remove_ObjectLoadedAction(Action<GameObject> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PrefabAsyncLoader.NativeMethodInfoPtr_remove_ObjectLoadedAction_Public_rem_Void_Action_1_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002D7D RID: 11645 RVA: 0x000C1F94 File Offset: 0x000C0194
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 212555, RefRangeEnd = 212556, XrefRangeStart = 212545, XrefRangeEnd = 212555, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static PrefabAsyncLoader Create()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PrefabAsyncLoader.NativeMethodInfoPtr_Create_Public_Static_PrefabAsyncLoader_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<PrefabAsyncLoader>(intPtr3) : null;
		}

		// Token: 0x06002D7E RID: 11646 RVA: 0x000C1FC8 File Offset: 0x000C01C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 212556, XrefRangeEnd = 212561, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PrefabAsyncLoader.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002D7F RID: 11647 RVA: 0x000C1FFC File Offset: 0x000C01FC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 212567, RefRangeEnd = 212568, XrefRangeStart = 212561, XrefRangeEnd = 212567, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LoadAsync(string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PrefabAsyncLoader.NativeMethodInfoPtr_LoadAsync_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002D80 RID: 11648 RVA: 0x000C2040 File Offset: 0x000C0240
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 212568, XrefRangeEnd = 212572, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator Load()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PrefabAsyncLoader.NativeMethodInfoPtr_Load_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06002D81 RID: 11649 RVA: 0x000C2080 File Offset: 0x000C0280
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 212572, XrefRangeEnd = 212589, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PrefabAsyncLoader()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PrefabAsyncLoader>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PrefabAsyncLoader.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002D82 RID: 11650 RVA: 0x00011A40 File Offset: 0x0000FC40
		public PrefabAsyncLoader(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000A50 RID: 2640
		// (get) Token: 0x06002D83 RID: 11651 RVA: 0x000C20BC File Offset: 0x000C02BC
		// (set) Token: 0x06002D84 RID: 11652 RVA: 0x00011A49 File Offset: 0x0000FC49
		public unsafe string PrefabPath
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PrefabAsyncLoader.NativeFieldInfoPtr_PrefabPath);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PrefabAsyncLoader.NativeFieldInfoPtr_PrefabPath), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000A51 RID: 2641
		// (get) Token: 0x06002D85 RID: 11653 RVA: 0x000C20E4 File Offset: 0x000C02E4
		// (set) Token: 0x06002D86 RID: 11654 RVA: 0x00011A68 File Offset: 0x0000FC68
		public unsafe Action<GameObject> ObjectLoadedAction
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PrefabAsyncLoader.NativeFieldInfoPtr_ObjectLoadedAction);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<GameObject>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PrefabAsyncLoader.NativeFieldInfoPtr_ObjectLoadedAction), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04002B66 RID: 11110
		private static readonly IntPtr NativeFieldInfoPtr_PrefabPath;

		// Token: 0x04002B67 RID: 11111
		private static readonly IntPtr NativeFieldInfoPtr_ObjectLoadedAction;

		// Token: 0x04002B68 RID: 11112
		private static readonly IntPtr NativeMethodInfoPtr_add_ObjectLoadedAction_Public_add_Void_Action_1_GameObject_0;

		// Token: 0x04002B69 RID: 11113
		private static readonly IntPtr NativeMethodInfoPtr_remove_ObjectLoadedAction_Public_rem_Void_Action_1_GameObject_0;

		// Token: 0x04002B6A RID: 11114
		private static readonly IntPtr NativeMethodInfoPtr_Create_Public_Static_PrefabAsyncLoader_0;

		// Token: 0x04002B6B RID: 11115
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x04002B6C RID: 11116
		private static readonly IntPtr NativeMethodInfoPtr_LoadAsync_Public_Void_String_0;

		// Token: 0x04002B6D RID: 11117
		private static readonly IntPtr NativeMethodInfoPtr_Load_Private_IEnumerator_0;

		// Token: 0x04002B6E RID: 11118
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020003CD RID: 973
		[ObfuscatedName("SA.Common.Models.PrefabAsyncLoader+<Load>d__7")]
		public sealed class _Load_d__7 : global::Il2CppSystem.Object
		{
			// Token: 0x06003870 RID: 14448 RVA: 0x000E5CB0 File Offset: 0x000E3EB0
			// Note: this type is marked as 'beforefieldinit'.
			static _Load_d__7()
			{
				Il2CppClassPointerStore<PrefabAsyncLoader._Load_d__7>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PrefabAsyncLoader>.NativeClassPtr, "<Load>d__7");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PrefabAsyncLoader._Load_d__7>.NativeClassPtr);
				PrefabAsyncLoader._Load_d__7.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrefabAsyncLoader._Load_d__7>.NativeClassPtr, "<>1__state");
				PrefabAsyncLoader._Load_d__7.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrefabAsyncLoader._Load_d__7>.NativeClassPtr, "<>2__current");
				PrefabAsyncLoader._Load_d__7.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrefabAsyncLoader._Load_d__7>.NativeClassPtr, "<>4__this");
				PrefabAsyncLoader._Load_d__7.NativeFieldInfoPtr__request_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrefabAsyncLoader._Load_d__7>.NativeClassPtr, "<request>5__2");
				PrefabAsyncLoader._Load_d__7.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefabAsyncLoader._Load_d__7>.NativeClassPtr, 100670439);
				PrefabAsyncLoader._Load_d__7.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefabAsyncLoader._Load_d__7>.NativeClassPtr, 100670440);
				PrefabAsyncLoader._Load_d__7.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefabAsyncLoader._Load_d__7>.NativeClassPtr, 100670441);
				PrefabAsyncLoader._Load_d__7.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefabAsyncLoader._Load_d__7>.NativeClassPtr, 100670442);
				PrefabAsyncLoader._Load_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefabAsyncLoader._Load_d__7>.NativeClassPtr, 100670443);
				PrefabAsyncLoader._Load_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefabAsyncLoader._Load_d__7>.NativeClassPtr, 100670444);
			}

			// Token: 0x06003871 RID: 14449 RVA: 0x000E5DA4 File Offset: 0x000E3FA4
			[CallerCount(208)]
			[CachedScanResults(RefRangeStart = 8591, RefRangeEnd = 8799, XrefRangeStart = 8591, XrefRangeEnd = 8799, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _Load_d__7(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PrefabAsyncLoader._Load_d__7>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PrefabAsyncLoader._Load_d__7.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06003872 RID: 14450 RVA: 0x000E5DEC File Offset: 0x000E3FEC
			[CallerCount(3728)]
			[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PrefabAsyncLoader._Load_d__7.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003873 RID: 14451 RVA: 0x000E5E20 File Offset: 0x000E4020
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 212525, XrefRangeEnd = 212531, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PrefabAsyncLoader._Load_d__7.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000D57 RID: 3415
			// (get) Token: 0x06003874 RID: 14452 RVA: 0x000E5E5C File Offset: 0x000E405C
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(7)]
				[CachedScanResults(RefRangeStart = 5312, RefRangeEnd = 5319, XrefRangeStart = 5312, XrefRangeEnd = 5319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PrefabAsyncLoader._Load_d__7.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06003875 RID: 14453 RVA: 0x000E5E9C File Offset: 0x000E409C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 212531, XrefRangeEnd = 212536, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PrefabAsyncLoader._Load_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000D58 RID: 3416
			// (get) Token: 0x06003876 RID: 14454 RVA: 0x000E5ED0 File Offset: 0x000E40D0
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(7)]
				[CachedScanResults(RefRangeStart = 5312, RefRangeEnd = 5319, XrefRangeStart = 5312, XrefRangeEnd = 5319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PrefabAsyncLoader._Load_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06003877 RID: 14455 RVA: 0x00015DA2 File Offset: 0x00013FA2
			public _Load_d__7(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000D53 RID: 3411
			// (get) Token: 0x06003878 RID: 14456 RVA: 0x000E5F10 File Offset: 0x000E4110
			// (set) Token: 0x06003879 RID: 14457 RVA: 0x00015DAB File Offset: 0x00013FAB
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PrefabAsyncLoader._Load_d__7.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PrefabAsyncLoader._Load_d__7.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000D54 RID: 3412
			// (get) Token: 0x0600387A RID: 14458 RVA: 0x000E5F38 File Offset: 0x000E4138
			// (set) Token: 0x0600387B RID: 14459 RVA: 0x00015DC6 File Offset: 0x00013FC6
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PrefabAsyncLoader._Load_d__7.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PrefabAsyncLoader._Load_d__7.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000D55 RID: 3413
			// (get) Token: 0x0600387C RID: 14460 RVA: 0x000E5F68 File Offset: 0x000E4168
			// (set) Token: 0x0600387D RID: 14461 RVA: 0x00015DE5 File Offset: 0x00013FE5
			public unsafe PrefabAsyncLoader __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PrefabAsyncLoader._Load_d__7.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PrefabAsyncLoader>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PrefabAsyncLoader._Load_d__7.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000D56 RID: 3414
			// (get) Token: 0x0600387E RID: 14462 RVA: 0x000E5F98 File Offset: 0x000E4198
			// (set) Token: 0x0600387F RID: 14463 RVA: 0x00015E04 File Offset: 0x00014004
			public unsafe ResourceRequest _request_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PrefabAsyncLoader._Load_d__7.NativeFieldInfoPtr__request_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ResourceRequest>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PrefabAsyncLoader._Load_d__7.NativeFieldInfoPtr__request_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040032F0 RID: 13040
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040032F1 RID: 13041
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040032F2 RID: 13042
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040032F3 RID: 13043
			private static readonly IntPtr NativeFieldInfoPtr__request_5__2;

			// Token: 0x040032F4 RID: 13044
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040032F5 RID: 13045
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040032F6 RID: 13046
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040032F7 RID: 13047
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040032F8 RID: 13048
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040032F9 RID: 13049
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x020003CE RID: 974
		[ObfuscatedName("SA.Common.Models.PrefabAsyncLoader+<>c")]
		[Serializable]
		public sealed class __c : global::Il2CppSystem.Object
		{
			// Token: 0x06003880 RID: 14464 RVA: 0x000E5FC8 File Offset: 0x000E41C8
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<PrefabAsyncLoader.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PrefabAsyncLoader>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PrefabAsyncLoader.__c>.NativeClassPtr);
				PrefabAsyncLoader.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrefabAsyncLoader.__c>.NativeClassPtr, "<>9");
				PrefabAsyncLoader.__c.NativeFieldInfoPtr___9__8_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrefabAsyncLoader.__c>.NativeClassPtr, "<>9__8_0");
				PrefabAsyncLoader.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefabAsyncLoader.__c>.NativeClassPtr, 100670446);
				PrefabAsyncLoader.__c.NativeMethodInfoPtr___ctor_b__8_0_Internal_Void_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefabAsyncLoader.__c>.NativeClassPtr, 100670447);
			}

			// Token: 0x06003881 RID: 14465 RVA: 0x000E6044 File Offset: 0x000E4244
			[CallerCount(817)]
			[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PrefabAsyncLoader.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PrefabAsyncLoader.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003882 RID: 14466 RVA: 0x000E6080 File Offset: 0x000E4280
			[CallerCount(3728)]
			[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __ctor_b__8_0(GameObject <p0>)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(<p0>);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PrefabAsyncLoader.__c.NativeMethodInfoPtr___ctor_b__8_0_Internal_Void_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06003883 RID: 14467 RVA: 0x00015E23 File Offset: 0x00014023
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000D59 RID: 3417
			// (get) Token: 0x06003884 RID: 14468 RVA: 0x000E60C4 File Offset: 0x000E42C4
			// (set) Token: 0x06003885 RID: 14469 RVA: 0x00015E2C File Offset: 0x0001402C
			public unsafe static PrefabAsyncLoader.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(PrefabAsyncLoader.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PrefabAsyncLoader.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(PrefabAsyncLoader.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000D5A RID: 3418
			// (get) Token: 0x06003886 RID: 14470 RVA: 0x000E60EC File Offset: 0x000E42EC
			// (set) Token: 0x06003887 RID: 14471 RVA: 0x00015E3E File Offset: 0x0001403E
			public unsafe static Action<GameObject> __9__8_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(PrefabAsyncLoader.__c.NativeFieldInfoPtr___9__8_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<GameObject>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(PrefabAsyncLoader.__c.NativeFieldInfoPtr___9__8_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040032FA RID: 13050
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x040032FB RID: 13051
			private static readonly IntPtr NativeFieldInfoPtr___9__8_0;

			// Token: 0x040032FC RID: 13052
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040032FD RID: 13053
			private static readonly IntPtr NativeMethodInfoPtr___ctor_b__8_0_Internal_Void_GameObject_0;
		}
	}
}
