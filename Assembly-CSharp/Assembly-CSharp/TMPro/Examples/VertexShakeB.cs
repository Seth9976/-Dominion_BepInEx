using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnityEngine;

namespace TMPro.Examples
{
	// Token: 0x02000116 RID: 278
	public class VertexShakeB : MonoBehaviour
	{
		// Token: 0x06002032 RID: 8242 RVA: 0x0007BEF8 File Offset: 0x0007A0F8
		// Note: this type is marked as 'beforefieldinit'.
		static VertexShakeB()
		{
			Il2CppClassPointerStore<VertexShakeB>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "TMPro.Examples", "VertexShakeB");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VertexShakeB>.NativeClassPtr);
			VertexShakeB.NativeFieldInfoPtr_AngleMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VertexShakeB>.NativeClassPtr, "AngleMultiplier");
			VertexShakeB.NativeFieldInfoPtr_SpeedMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VertexShakeB>.NativeClassPtr, "SpeedMultiplier");
			VertexShakeB.NativeFieldInfoPtr_CurveScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VertexShakeB>.NativeClassPtr, "CurveScale");
			VertexShakeB.NativeFieldInfoPtr_m_TextComponent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VertexShakeB>.NativeClassPtr, "m_TextComponent");
			VertexShakeB.NativeFieldInfoPtr_hasTextChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VertexShakeB>.NativeClassPtr, "hasTextChanged");
			VertexShakeB.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VertexShakeB>.NativeClassPtr, 100665915);
			VertexShakeB.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VertexShakeB>.NativeClassPtr, 100665916);
			VertexShakeB.NativeMethodInfoPtr_OnDisable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VertexShakeB>.NativeClassPtr, 100665917);
			VertexShakeB.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VertexShakeB>.NativeClassPtr, 100665918);
			VertexShakeB.NativeMethodInfoPtr_ON_TEXT_CHANGED_Private_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VertexShakeB>.NativeClassPtr, 100665919);
			VertexShakeB.NativeMethodInfoPtr_AnimateVertexColors_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VertexShakeB>.NativeClassPtr, 100665920);
			VertexShakeB.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VertexShakeB>.NativeClassPtr, 100665921);
		}

		// Token: 0x06002033 RID: 8243 RVA: 0x0007C018 File Offset: 0x0007A218
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 257219, XrefRangeEnd = 257222, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VertexShakeB.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002034 RID: 8244 RVA: 0x0007C04C File Offset: 0x0007A24C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 257222, XrefRangeEnd = 257238, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VertexShakeB.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002035 RID: 8245 RVA: 0x0007C080 File Offset: 0x0007A280
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 257238, XrefRangeEnd = 257254, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDisable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VertexShakeB.NativeMethodInfoPtr_OnDisable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002036 RID: 8246 RVA: 0x0007C0B4 File Offset: 0x0007A2B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 257254, XrefRangeEnd = 257260, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VertexShakeB.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002037 RID: 8247 RVA: 0x0007C0E8 File Offset: 0x0007A2E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 257260, XrefRangeEnd = 257264, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ON_TEXT_CHANGED(global::UnityEngine.Object obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VertexShakeB.NativeMethodInfoPtr_ON_TEXT_CHANGED_Private_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002038 RID: 8248 RVA: 0x0007C12C File Offset: 0x0007A32C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 257264, XrefRangeEnd = 257268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator AnimateVertexColors()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VertexShakeB.NativeMethodInfoPtr_AnimateVertexColors_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06002039 RID: 8249 RVA: 0x0007C16C File Offset: 0x0007A36C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe VertexShakeB()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VertexShakeB>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VertexShakeB.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600203A RID: 8250 RVA: 0x000140C3 File Offset: 0x000122C3
		public VertexShakeB(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000A4C RID: 2636
		// (get) Token: 0x0600203B RID: 8251 RVA: 0x0007C1A8 File Offset: 0x0007A3A8
		// (set) Token: 0x0600203C RID: 8252 RVA: 0x000140CC File Offset: 0x000122CC
		public unsafe float AngleMultiplier
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VertexShakeB.NativeFieldInfoPtr_AngleMultiplier);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VertexShakeB.NativeFieldInfoPtr_AngleMultiplier)) = value;
			}
		}

		// Token: 0x17000A4D RID: 2637
		// (get) Token: 0x0600203D RID: 8253 RVA: 0x0007C1D0 File Offset: 0x0007A3D0
		// (set) Token: 0x0600203E RID: 8254 RVA: 0x000140E7 File Offset: 0x000122E7
		public unsafe float SpeedMultiplier
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VertexShakeB.NativeFieldInfoPtr_SpeedMultiplier);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VertexShakeB.NativeFieldInfoPtr_SpeedMultiplier)) = value;
			}
		}

		// Token: 0x17000A4E RID: 2638
		// (get) Token: 0x0600203F RID: 8255 RVA: 0x0007C1F8 File Offset: 0x0007A3F8
		// (set) Token: 0x06002040 RID: 8256 RVA: 0x00014102 File Offset: 0x00012302
		public unsafe float CurveScale
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VertexShakeB.NativeFieldInfoPtr_CurveScale);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VertexShakeB.NativeFieldInfoPtr_CurveScale)) = value;
			}
		}

		// Token: 0x17000A4F RID: 2639
		// (get) Token: 0x06002041 RID: 8257 RVA: 0x0007C220 File Offset: 0x0007A420
		// (set) Token: 0x06002042 RID: 8258 RVA: 0x0001411D File Offset: 0x0001231D
		public unsafe TMP_Text m_TextComponent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VertexShakeB.NativeFieldInfoPtr_m_TextComponent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VertexShakeB.NativeFieldInfoPtr_m_TextComponent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A50 RID: 2640
		// (get) Token: 0x06002043 RID: 8259 RVA: 0x0007C250 File Offset: 0x0007A450
		// (set) Token: 0x06002044 RID: 8260 RVA: 0x0001413C File Offset: 0x0001233C
		public unsafe bool hasTextChanged
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VertexShakeB.NativeFieldInfoPtr_hasTextChanged);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VertexShakeB.NativeFieldInfoPtr_hasTextChanged)) = value;
			}
		}

		// Token: 0x040015A3 RID: 5539
		private static readonly IntPtr NativeFieldInfoPtr_AngleMultiplier;

		// Token: 0x040015A4 RID: 5540
		private static readonly IntPtr NativeFieldInfoPtr_SpeedMultiplier;

		// Token: 0x040015A5 RID: 5541
		private static readonly IntPtr NativeFieldInfoPtr_CurveScale;

		// Token: 0x040015A6 RID: 5542
		private static readonly IntPtr NativeFieldInfoPtr_m_TextComponent;

		// Token: 0x040015A7 RID: 5543
		private static readonly IntPtr NativeFieldInfoPtr_hasTextChanged;

		// Token: 0x040015A8 RID: 5544
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x040015A9 RID: 5545
		private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;

		// Token: 0x040015AA RID: 5546
		private static readonly IntPtr NativeMethodInfoPtr_OnDisable_Private_Void_0;

		// Token: 0x040015AB RID: 5547
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x040015AC RID: 5548
		private static readonly IntPtr NativeMethodInfoPtr_ON_TEXT_CHANGED_Private_Void_Object_0;

		// Token: 0x040015AD RID: 5549
		private static readonly IntPtr NativeMethodInfoPtr_AnimateVertexColors_Private_IEnumerator_0;

		// Token: 0x040015AE RID: 5550
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000235 RID: 565
		[ObfuscatedName("TMPro.Examples.VertexShakeB+<AnimateVertexColors>d__10")]
		public sealed class _AnimateVertexColors_d__10 : global::Il2CppSystem.Object
		{
			// Token: 0x06002B53 RID: 11091 RVA: 0x0009AA00 File Offset: 0x00098C00
			// Note: this type is marked as 'beforefieldinit'.
			static _AnimateVertexColors_d__10()
			{
				Il2CppClassPointerStore<VertexShakeB._AnimateVertexColors_d__10>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<VertexShakeB>.NativeClassPtr, "<AnimateVertexColors>d__10");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VertexShakeB._AnimateVertexColors_d__10>.NativeClassPtr);
				VertexShakeB._AnimateVertexColors_d__10.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VertexShakeB._AnimateVertexColors_d__10>.NativeClassPtr, "<>1__state");
				VertexShakeB._AnimateVertexColors_d__10.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VertexShakeB._AnimateVertexColors_d__10>.NativeClassPtr, "<>2__current");
				VertexShakeB._AnimateVertexColors_d__10.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VertexShakeB._AnimateVertexColors_d__10>.NativeClassPtr, "<>4__this");
				VertexShakeB._AnimateVertexColors_d__10.NativeFieldInfoPtr__textInfo_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VertexShakeB._AnimateVertexColors_d__10>.NativeClassPtr, "<textInfo>5__2");
				VertexShakeB._AnimateVertexColors_d__10.NativeFieldInfoPtr__copyOfVertices_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VertexShakeB._AnimateVertexColors_d__10>.NativeClassPtr, "<copyOfVertices>5__3");
				VertexShakeB._AnimateVertexColors_d__10.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VertexShakeB._AnimateVertexColors_d__10>.NativeClassPtr, 100666707);
				VertexShakeB._AnimateVertexColors_d__10.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VertexShakeB._AnimateVertexColors_d__10>.NativeClassPtr, 100666708);
				VertexShakeB._AnimateVertexColors_d__10.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VertexShakeB._AnimateVertexColors_d__10>.NativeClassPtr, 100666709);
				VertexShakeB._AnimateVertexColors_d__10.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VertexShakeB._AnimateVertexColors_d__10>.NativeClassPtr, 100666710);
				VertexShakeB._AnimateVertexColors_d__10.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VertexShakeB._AnimateVertexColors_d__10>.NativeClassPtr, 100666711);
				VertexShakeB._AnimateVertexColors_d__10.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VertexShakeB._AnimateVertexColors_d__10>.NativeClassPtr, 100666712);
			}

			// Token: 0x06002B54 RID: 11092 RVA: 0x0009AB08 File Offset: 0x00098D08
			[CallerCount(208)]
			[CachedScanResults(RefRangeStart = 8591, RefRangeEnd = 8799, XrefRangeStart = 8591, XrefRangeEnd = 8799, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _AnimateVertexColors_d__10(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VertexShakeB._AnimateVertexColors_d__10>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VertexShakeB._AnimateVertexColors_d__10.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002B55 RID: 11093 RVA: 0x0009AB50 File Offset: 0x00098D50
			[CallerCount(3728)]
			[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VertexShakeB._AnimateVertexColors_d__10.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002B56 RID: 11094 RVA: 0x0009AB84 File Offset: 0x00098D84
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 257178, XrefRangeEnd = 257214, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VertexShakeB._AnimateVertexColors_d__10.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000DB9 RID: 3513
			// (get) Token: 0x06002B57 RID: 11095 RVA: 0x0009ABC0 File Offset: 0x00098DC0
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(7)]
				[CachedScanResults(RefRangeStart = 5312, RefRangeEnd = 5319, XrefRangeStart = 5312, XrefRangeEnd = 5319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VertexShakeB._AnimateVertexColors_d__10.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06002B58 RID: 11096 RVA: 0x0009AC00 File Offset: 0x00098E00
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 257214, XrefRangeEnd = 257219, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VertexShakeB._AnimateVertexColors_d__10.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000DBA RID: 3514
			// (get) Token: 0x06002B59 RID: 11097 RVA: 0x0009AC34 File Offset: 0x00098E34
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(7)]
				[CachedScanResults(RefRangeStart = 5312, RefRangeEnd = 5319, XrefRangeStart = 5312, XrefRangeEnd = 5319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VertexShakeB._AnimateVertexColors_d__10.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06002B5A RID: 11098 RVA: 0x0001A94F File Offset: 0x00018B4F
			public _AnimateVertexColors_d__10(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000DB4 RID: 3508
			// (get) Token: 0x06002B5B RID: 11099 RVA: 0x0009AC74 File Offset: 0x00098E74
			// (set) Token: 0x06002B5C RID: 11100 RVA: 0x0001A958 File Offset: 0x00018B58
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VertexShakeB._AnimateVertexColors_d__10.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VertexShakeB._AnimateVertexColors_d__10.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000DB5 RID: 3509
			// (get) Token: 0x06002B5D RID: 11101 RVA: 0x0009AC9C File Offset: 0x00098E9C
			// (set) Token: 0x06002B5E RID: 11102 RVA: 0x0001A973 File Offset: 0x00018B73
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VertexShakeB._AnimateVertexColors_d__10.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VertexShakeB._AnimateVertexColors_d__10.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000DB6 RID: 3510
			// (get) Token: 0x06002B5F RID: 11103 RVA: 0x0009ACCC File Offset: 0x00098ECC
			// (set) Token: 0x06002B60 RID: 11104 RVA: 0x0001A992 File Offset: 0x00018B92
			public unsafe VertexShakeB __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VertexShakeB._AnimateVertexColors_d__10.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<VertexShakeB>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VertexShakeB._AnimateVertexColors_d__10.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000DB7 RID: 3511
			// (get) Token: 0x06002B61 RID: 11105 RVA: 0x0009ACFC File Offset: 0x00098EFC
			// (set) Token: 0x06002B62 RID: 11106 RVA: 0x0001A9B1 File Offset: 0x00018BB1
			public unsafe TMP_TextInfo _textInfo_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VertexShakeB._AnimateVertexColors_d__10.NativeFieldInfoPtr__textInfo_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_TextInfo>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VertexShakeB._AnimateVertexColors_d__10.NativeFieldInfoPtr__textInfo_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000DB8 RID: 3512
			// (get) Token: 0x06002B63 RID: 11107 RVA: 0x0009AD2C File Offset: 0x00098F2C
			// (set) Token: 0x06002B64 RID: 11108 RVA: 0x0001A9D0 File Offset: 0x00018BD0
			public unsafe Il2CppReferenceArray<Il2CppStructArray<Vector3>> _copyOfVertices_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VertexShakeB._AnimateVertexColors_d__10.NativeFieldInfoPtr__copyOfVertices_5__3);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Il2CppStructArray<Vector3>>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VertexShakeB._AnimateVertexColors_d__10.NativeFieldInfoPtr__copyOfVertices_5__3), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001DA6 RID: 7590
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04001DA7 RID: 7591
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04001DA8 RID: 7592
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04001DA9 RID: 7593
			private static readonly IntPtr NativeFieldInfoPtr__textInfo_5__2;

			// Token: 0x04001DAA RID: 7594
			private static readonly IntPtr NativeFieldInfoPtr__copyOfVertices_5__3;

			// Token: 0x04001DAB RID: 7595
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04001DAC RID: 7596
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001DAD RID: 7597
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04001DAE RID: 7598
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04001DAF RID: 7599
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001DB0 RID: 7600
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
