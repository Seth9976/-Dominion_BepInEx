using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnityEngine;

namespace SA.Common.Models
{
	// Token: 0x02000319 RID: 793
	public class ScreenshotMaker : MonoBehaviour
	{
		// Token: 0x06002D91 RID: 11665 RVA: 0x000C237C File Offset: 0x000C057C
		// Note: this type is marked as 'beforefieldinit'.
		static ScreenshotMaker()
		{
			Il2CppClassPointerStore<ScreenshotMaker>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "SA.Common.Models", "ScreenshotMaker");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ScreenshotMaker>.NativeClassPtr);
			ScreenshotMaker.NativeFieldInfoPtr_OnScreenshotReady = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenshotMaker>.NativeClassPtr, "OnScreenshotReady");
			ScreenshotMaker.NativeMethodInfoPtr_Create_Public_Static_ScreenshotMaker_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScreenshotMaker>.NativeClassPtr, 100669248);
			ScreenshotMaker.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScreenshotMaker>.NativeClassPtr, 100669249);
			ScreenshotMaker.NativeMethodInfoPtr_GetScreenshot_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScreenshotMaker>.NativeClassPtr, 100669250);
			ScreenshotMaker.NativeMethodInfoPtr_SaveScreenshot_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScreenshotMaker>.NativeClassPtr, 100669251);
			ScreenshotMaker.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScreenshotMaker>.NativeClassPtr, 100669252);
		}

		// Token: 0x06002D92 RID: 11666 RVA: 0x000C2424 File Offset: 0x000C0624
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 212624, XrefRangeEnd = 212634, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ScreenshotMaker Create()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScreenshotMaker.NativeMethodInfoPtr_Create_Public_Static_ScreenshotMaker_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ScreenshotMaker>(intPtr3) : null;
		}

		// Token: 0x06002D93 RID: 11667 RVA: 0x000C2458 File Offset: 0x000C0658
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 212634, XrefRangeEnd = 212639, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScreenshotMaker.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002D94 RID: 11668 RVA: 0x000C248C File Offset: 0x000C068C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 212639, XrefRangeEnd = 212645, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GetScreenshot()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScreenshotMaker.NativeMethodInfoPtr_GetScreenshot_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002D95 RID: 11669 RVA: 0x000C24C0 File Offset: 0x000C06C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 212645, XrefRangeEnd = 212649, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator SaveScreenshot()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScreenshotMaker.NativeMethodInfoPtr_SaveScreenshot_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06002D96 RID: 11670 RVA: 0x000C2500 File Offset: 0x000C0700
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 212649, XrefRangeEnd = 212666, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ScreenshotMaker()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ScreenshotMaker>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScreenshotMaker.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002D97 RID: 11671 RVA: 0x00011AAF File Offset: 0x0000FCAF
		public ScreenshotMaker(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000A57 RID: 2647
		// (get) Token: 0x06002D98 RID: 11672 RVA: 0x000C253C File Offset: 0x000C073C
		// (set) Token: 0x06002D99 RID: 11673 RVA: 0x00011AB8 File Offset: 0x0000FCB8
		public unsafe Action<Texture2D> OnScreenshotReady
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScreenshotMaker.NativeFieldInfoPtr_OnScreenshotReady);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<Texture2D>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScreenshotMaker.NativeFieldInfoPtr_OnScreenshotReady), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04002B76 RID: 11126
		private static readonly IntPtr NativeFieldInfoPtr_OnScreenshotReady;

		// Token: 0x04002B77 RID: 11127
		private static readonly IntPtr NativeMethodInfoPtr_Create_Public_Static_ScreenshotMaker_0;

		// Token: 0x04002B78 RID: 11128
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x04002B79 RID: 11129
		private static readonly IntPtr NativeMethodInfoPtr_GetScreenshot_Public_Void_0;

		// Token: 0x04002B7A RID: 11130
		private static readonly IntPtr NativeMethodInfoPtr_SaveScreenshot_Private_IEnumerator_0;

		// Token: 0x04002B7B RID: 11131
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020003CF RID: 975
		[ObfuscatedName("SA.Common.Models.ScreenshotMaker+<SaveScreenshot>d__4")]
		public sealed class _SaveScreenshot_d__4 : global::Il2CppSystem.Object
		{
			// Token: 0x06003888 RID: 14472 RVA: 0x000E6114 File Offset: 0x000E4314
			// Note: this type is marked as 'beforefieldinit'.
			static _SaveScreenshot_d__4()
			{
				Il2CppClassPointerStore<ScreenshotMaker._SaveScreenshot_d__4>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ScreenshotMaker>.NativeClassPtr, "<SaveScreenshot>d__4");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ScreenshotMaker._SaveScreenshot_d__4>.NativeClassPtr);
				ScreenshotMaker._SaveScreenshot_d__4.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenshotMaker._SaveScreenshot_d__4>.NativeClassPtr, "<>1__state");
				ScreenshotMaker._SaveScreenshot_d__4.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenshotMaker._SaveScreenshot_d__4>.NativeClassPtr, "<>2__current");
				ScreenshotMaker._SaveScreenshot_d__4.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenshotMaker._SaveScreenshot_d__4>.NativeClassPtr, "<>4__this");
				ScreenshotMaker._SaveScreenshot_d__4.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScreenshotMaker._SaveScreenshot_d__4>.NativeClassPtr, 100670448);
				ScreenshotMaker._SaveScreenshot_d__4.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScreenshotMaker._SaveScreenshot_d__4>.NativeClassPtr, 100670449);
				ScreenshotMaker._SaveScreenshot_d__4.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScreenshotMaker._SaveScreenshot_d__4>.NativeClassPtr, 100670450);
				ScreenshotMaker._SaveScreenshot_d__4.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScreenshotMaker._SaveScreenshot_d__4>.NativeClassPtr, 100670451);
				ScreenshotMaker._SaveScreenshot_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScreenshotMaker._SaveScreenshot_d__4>.NativeClassPtr, 100670452);
				ScreenshotMaker._SaveScreenshot_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScreenshotMaker._SaveScreenshot_d__4>.NativeClassPtr, 100670453);
			}

			// Token: 0x06003889 RID: 14473 RVA: 0x000E61F4 File Offset: 0x000E43F4
			[CallerCount(208)]
			[CachedScanResults(RefRangeStart = 8591, RefRangeEnd = 8799, XrefRangeStart = 8591, XrefRangeEnd = 8799, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _SaveScreenshot_d__4(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ScreenshotMaker._SaveScreenshot_d__4>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScreenshotMaker._SaveScreenshot_d__4.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600388A RID: 14474 RVA: 0x000E623C File Offset: 0x000E443C
			[CallerCount(3728)]
			[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScreenshotMaker._SaveScreenshot_d__4.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600388B RID: 14475 RVA: 0x000E6270 File Offset: 0x000E4470
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 212612, XrefRangeEnd = 212619, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScreenshotMaker._SaveScreenshot_d__4.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000D5E RID: 3422
			// (get) Token: 0x0600388C RID: 14476 RVA: 0x000E62AC File Offset: 0x000E44AC
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(7)]
				[CachedScanResults(RefRangeStart = 5312, RefRangeEnd = 5319, XrefRangeStart = 5312, XrefRangeEnd = 5319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScreenshotMaker._SaveScreenshot_d__4.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600388D RID: 14477 RVA: 0x000E62EC File Offset: 0x000E44EC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 212619, XrefRangeEnd = 212624, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScreenshotMaker._SaveScreenshot_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000D5F RID: 3423
			// (get) Token: 0x0600388E RID: 14478 RVA: 0x000E6320 File Offset: 0x000E4520
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(7)]
				[CachedScanResults(RefRangeStart = 5312, RefRangeEnd = 5319, XrefRangeStart = 5312, XrefRangeEnd = 5319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScreenshotMaker._SaveScreenshot_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600388F RID: 14479 RVA: 0x00015E50 File Offset: 0x00014050
			public _SaveScreenshot_d__4(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000D5B RID: 3419
			// (get) Token: 0x06003890 RID: 14480 RVA: 0x000E6360 File Offset: 0x000E4560
			// (set) Token: 0x06003891 RID: 14481 RVA: 0x00015E59 File Offset: 0x00014059
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScreenshotMaker._SaveScreenshot_d__4.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScreenshotMaker._SaveScreenshot_d__4.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000D5C RID: 3420
			// (get) Token: 0x06003892 RID: 14482 RVA: 0x000E6388 File Offset: 0x000E4588
			// (set) Token: 0x06003893 RID: 14483 RVA: 0x00015E74 File Offset: 0x00014074
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScreenshotMaker._SaveScreenshot_d__4.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScreenshotMaker._SaveScreenshot_d__4.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000D5D RID: 3421
			// (get) Token: 0x06003894 RID: 14484 RVA: 0x000E63B8 File Offset: 0x000E45B8
			// (set) Token: 0x06003895 RID: 14485 RVA: 0x00015E93 File Offset: 0x00014093
			public unsafe ScreenshotMaker __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScreenshotMaker._SaveScreenshot_d__4.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ScreenshotMaker>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScreenshotMaker._SaveScreenshot_d__4.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040032FE RID: 13054
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040032FF RID: 13055
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04003300 RID: 13056
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04003301 RID: 13057
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04003302 RID: 13058
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04003303 RID: 13059
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04003304 RID: 13060
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04003305 RID: 13061
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04003306 RID: 13062
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x020003D0 RID: 976
		[ObfuscatedName("SA.Common.Models.ScreenshotMaker+<>c")]
		[Serializable]
		public sealed class __c : global::Il2CppSystem.Object
		{
			// Token: 0x06003896 RID: 14486 RVA: 0x000E63E8 File Offset: 0x000E45E8
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<ScreenshotMaker.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ScreenshotMaker>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ScreenshotMaker.__c>.NativeClassPtr);
				ScreenshotMaker.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenshotMaker.__c>.NativeClassPtr, "<>9");
				ScreenshotMaker.__c.NativeFieldInfoPtr___9__5_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenshotMaker.__c>.NativeClassPtr, "<>9__5_0");
				ScreenshotMaker.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScreenshotMaker.__c>.NativeClassPtr, 100670455);
				ScreenshotMaker.__c.NativeMethodInfoPtr___ctor_b__5_0_Internal_Void_Texture2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScreenshotMaker.__c>.NativeClassPtr, 100670456);
			}

			// Token: 0x06003897 RID: 14487 RVA: 0x000E6464 File Offset: 0x000E4664
			[CallerCount(817)]
			[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ScreenshotMaker.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScreenshotMaker.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003898 RID: 14488 RVA: 0x000E64A0 File Offset: 0x000E46A0
			[CallerCount(3728)]
			[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __ctor_b__5_0(Texture2D <p0>)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(<p0>);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScreenshotMaker.__c.NativeMethodInfoPtr___ctor_b__5_0_Internal_Void_Texture2D_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06003899 RID: 14489 RVA: 0x00015EB2 File Offset: 0x000140B2
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000D60 RID: 3424
			// (get) Token: 0x0600389A RID: 14490 RVA: 0x000E64E4 File Offset: 0x000E46E4
			// (set) Token: 0x0600389B RID: 14491 RVA: 0x00015EBB File Offset: 0x000140BB
			public unsafe static ScreenshotMaker.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ScreenshotMaker.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ScreenshotMaker.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ScreenshotMaker.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000D61 RID: 3425
			// (get) Token: 0x0600389C RID: 14492 RVA: 0x000E650C File Offset: 0x000E470C
			// (set) Token: 0x0600389D RID: 14493 RVA: 0x00015ECD File Offset: 0x000140CD
			public unsafe static Action<Texture2D> __9__5_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ScreenshotMaker.__c.NativeFieldInfoPtr___9__5_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<Texture2D>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ScreenshotMaker.__c.NativeFieldInfoPtr___9__5_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04003307 RID: 13063
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04003308 RID: 13064
			private static readonly IntPtr NativeFieldInfoPtr___9__5_0;

			// Token: 0x04003309 RID: 13065
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400330A RID: 13066
			private static readonly IntPtr NativeMethodInfoPtr___ctor_b__5_0_Internal_Void_Texture2D_0;
		}
	}
}
